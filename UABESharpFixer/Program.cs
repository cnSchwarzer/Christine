using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace UABESharpFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            FixWrapper();
        }

        private static void FixWrapper()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(
                @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UABESharp
{");
            Assembly assembly = Assembly.LoadFile(new DirectoryInfo("./UABESharp.dll").FullName);
            Module module = assembly.GetModule("UABESharp.dll");
            Type[] uabeTypes = module.GetTypes();
            foreach (Type uabeType in uabeTypes)
            {
                if (uabeType.IsNested) continue;

                bool ClassPrinted = false;

                PropertyInfo[] uabeTypeProperties = uabeType.GetProperties();
                foreach (PropertyInfo uabeTypeProperty in uabeTypeProperties)
                {
                    Type propertyType = uabeTypeProperty.PropertyType;
                    if (propertyType.Equals(typeof(sbyte[])))
                    {
                        if (!ClassPrinted)
                        {
                            stringBuilder.AppendLine($"    public unsafe partial class {uabeType.Name}");
                            stringBuilder.AppendLine("    {");
                            ClassPrinted = true;
                        }
                        stringBuilder.AppendLine($"        public string {uabeTypeProperty.Name}String");
                        stringBuilder.AppendLine(@"        {");
                        stringBuilder.AppendLine(@"            get");
                        stringBuilder.AppendLine(@"            {");
                        stringBuilder.AppendLine(@"                return Encoding.UTF8.GetString(" + $"{uabeTypeProperty.Name}.Select(b => (byte)b).ToArray()).Replace(" + "\"" + @"\0" + "\"" + ", " + "\"\"" + @");");
                        stringBuilder.AppendLine(@"            }");
                        stringBuilder.AppendLine(@"            set");
                        stringBuilder.AppendLine(@"            {");
                        stringBuilder.AppendLine($"                {uabeTypeProperty.Name} = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();");
                        stringBuilder.AppendLine(@"            }");
                        stringBuilder.AppendLine(@"        }");

                    }
                }

                MethodInfo[] uabeTypeMethods = uabeType.GetMethods();
                foreach(MethodInfo uabeTypeMethod in uabeTypeMethods)
                {

                }

                if (ClassPrinted)
                {
                    stringBuilder.AppendLine(@"    }");
                }
            }

            stringBuilder.AppendLine("}");
            string FixFile = stringBuilder.ToString();
        }
    }
}

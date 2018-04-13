using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UABESharp
{
    public unsafe partial class PluginInfo
    {
        public string NameString
        {
            get
            {
                return Encoding.UTF8.GetString(Name.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Name = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class PluginAssetOption
    {
        public string DescString
        {
            get
            {
                return Encoding.UTF8.GetString(Desc.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Desc = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class ClassDatabaseFileHeader
    {
        public string HeaderString
        {
            get
            {
                return Encoding.UTF8.GetString(Header.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Header = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class AssetsFileDependency
    {
        public string BufferedPathString
        {
            get
            {
                return Encoding.UTF8.GetString(BufferedPath.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                BufferedPath = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string AssetPathString
        {
            get
            {
                return Encoding.UTF8.GetString(AssetPath.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                AssetPath = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class TypeField07
    {
        public string TypeString
        {
            get
            {
                return Encoding.UTF8.GetString(Type.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Type = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string NameString
        {
            get
            {
                return Encoding.UTF8.GetString(Name.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Name = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class TypeTree
    {
        public string UnityVersionString
        {
            get
            {
                return Encoding.UTF8.GetString(UnityVersion.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                UnityVersion = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class AssetsBundleHeader03
    {
        public string SignatureString
        {
            get
            {
                return Encoding.UTF8.GetString(Signature.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Signature = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string MinPlayerVersionString
        {
            get
            {
                return Encoding.UTF8.GetString(MinPlayerVersion.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                MinPlayerVersion = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string FileEngineVersionString
        {
            get
            {
                return Encoding.UTF8.GetString(FileEngineVersion.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                FileEngineVersion = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class AssetsBundleHeader06
    {
        public string SignatureString
        {
            get
            {
                return Encoding.UTF8.GetString(Signature.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Signature = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string MinPlayerVersionString
        {
            get
            {
                return Encoding.UTF8.GetString(MinPlayerVersion.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                MinPlayerVersion = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
        public string FileEngineVersionString
        {
            get
            {
                return Encoding.UTF8.GetString(FileEngineVersion.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                FileEngineVersion = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class AssetsBundleEntry
    {
        public string NameString
        {
            get
            {
                return Encoding.UTF8.GetString(Name.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Name = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
    public unsafe partial class AssetFileInfoEx
    {
        public string NameString
        {
            get
            {
                return Encoding.UTF8.GetString(Name.Select(b => (byte)b).ToArray()).Replace("\0", "");
            }
            set
            {
                Name = Encoding.UTF8.GetBytes(value).Select(b => (sbyte)b).ToArray();
            }
        }
    }
}

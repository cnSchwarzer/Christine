using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UABESharp;
using System.IO;

namespace UABESharpTester
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] b = File.ReadAllBytes(@"resources.assets");
            int Reader =  AssetsFileReader.CreateAssetsReaderFromMemory(b, (uint)b.Length, true);
            AssetsFile assetsFile = new AssetsFile(AssetsFileReader.AssetsReaderFromMemory, Reader);
            AssetsFileTable assetsFileTable = new AssetsFileTable(assetsFile, true);
            for (int i = 0; i < assetsFileTable.AssetFileInfoCount; ++i)
            {
                AssetFileInfoEx Asset = assetsFileTable.GetAssetInfo((ulong)i);             
                if (Asset == null) continue;
                Console.WriteLine(Asset.Name);
            }
        }
    }
}

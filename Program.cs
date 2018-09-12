using System;
using System.IO;

namespace VCCode_Mac
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var subfolder in Directory.GetDirectories("../uploads"))
            {
                var metadataFilePath = Path.Combine(subfolder, "metadata.json");
                Console.WriteLine($"Reading {metadataFilePath}");
                
            }
        }
    }
}

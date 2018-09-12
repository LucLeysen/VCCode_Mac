using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

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

                var metadataCollection = GetMetadata(metadataFilePath);
            }
        }

        private static List<Metadata> GetMetadata(string metadataFilePath)
        {
            var settings = new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
            };
            var serializer = new DataContractJsonSerializer(typeof(List<Metadata>), settings);

            using (var metadataFileStream = File.Open(metadataFilePath, FileMode.Open))
            {
                 return (List<Metadata>)serializer.ReadObject(metadataFileStream);
            };
        }
    }
}

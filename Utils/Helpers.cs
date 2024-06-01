using Newtonsoft.Json;
using playtarky.Models;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace playtarky.Utils
{
    public static class Helpers
    {
        public static List<string> GetFileSystemList(string path, FileType returnType = FileType.All, bool returnFullPath = false, bool removeExtensions = false)
        {
            var dirList = Directory.GetDirectories(path).ToList();
            var fileList = Directory.GetFiles(path).ToList();
            var list = new List<string>();

            if (returnType == FileType.All || returnType == FileType.Directories)
            {
                foreach (var item in dirList)
                {
                    var stagingItem = item;
                    if (!returnFullPath)
                    {
                        stagingItem = StripFileName(stagingItem, true);
                    }
                    list.Add(stagingItem);
                }
            }

            if (returnType == FileType.All || returnType == FileType.Files)
            {
                foreach (var item in fileList)
                {
                    var stagingItem = item;
                    if (!returnFullPath)
                    {
                        stagingItem = StripFileName(stagingItem, false);
                    }
                    if (removeExtensions)
                    {
                        stagingItem = Path.GetFileNameWithoutExtension(stagingItem);
                    }
                    list.Add(stagingItem);
                }
            }

            return list;
        }

        public static string StripFileName(string name, bool isFolder)
        {
            var stripped = name.Substring(name.LastIndexOf('\\') + 1);
            if (isFolder) stripped = string.Concat(stripped, "\\");
            return stripped;
        }

        public static JsonFile<T> GetJsonFile<T>(string path)
        {
            // Deserialize the JSON string into a C# object
            return new JsonFile<T>
            {
                Path = path,
                File = JsonConvert.DeserializeObject<T>(File.ReadAllText(path))
            };
        }

        public enum FileType
        {
            All = 0,
            Files = 1,
            Directories = 2
        }
    }
}

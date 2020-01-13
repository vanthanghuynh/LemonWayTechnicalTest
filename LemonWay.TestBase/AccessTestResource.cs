using System;
using System.IO;

namespace LemonWay.TestBase
{
    public static class AccessTestResource
    {
        private static string _pathRoot = string.Concat(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, "\\XmlToJsonTestCases");

        public static string  GetTestResourceString(string fileName)
        {
            string path = string.Concat(_pathRoot, "\\", fileName);

            if (File.Exists(path))
                return File.ReadAllText(path);

            return string.Empty;
        }
    }
}

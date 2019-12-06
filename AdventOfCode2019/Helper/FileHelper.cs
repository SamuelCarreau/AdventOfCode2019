using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Helper
{
    public static class FileHelper
    {

        public static string[] ReadFile(string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), $@"..\..\PuzzleInput\{fileName}");
            string[] files = File.ReadAllLines(path);
            return files;
        }

        public static void WriteFile(string[] textInput,string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), $@"..\..\PuzzleOutput\{fileName}");
            using (StreamWriter file = new StreamWriter(path))
            {

                foreach (string line in textInput)
                {
                    file.WriteLine(line);
                }
            }


        }
        
    }
}

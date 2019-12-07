using AdventOfCode2019.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.FetchInputStrategy
{
    public class CSVFileStrategy : IFetchInputStrategy
    {
        public string[] ReadFile(string fileName)
        {
           return FileHelper.ReadCSVFile(fileName);
        }
    }
}

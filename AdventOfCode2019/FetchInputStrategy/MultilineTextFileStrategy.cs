using AdventOfCode2019.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.FetchInputStrategy
{
    public class MultilineTextFileStrategy : IFetchInputStrategy
    {
        public string[] ReadFile(string puzzleName)
        {
            string[] puzzleInput = FileHelper.ReadFileLines($"{puzzleName}.txt");
            return puzzleInput;
        }
    }
}

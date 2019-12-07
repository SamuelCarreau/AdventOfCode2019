using AdventOfCode2019.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application
{
    public abstract class BasePuzzle : IAdventOfCodePuzzle
    {
        public string PuzzleName { get; }

        public BasePuzzle(string puzzleName)
        {
            PuzzleName = puzzleName;
        }
        public abstract string[] RunFirst(string[] input);

        public abstract string[] RunSecond(string[] input);
    }
}

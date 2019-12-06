using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application.Interface
{
    public interface IAdventOfCodePuzzle
    {
        string PuzzleName { get; }
        string[] RunFirst(string[] input);
        string[] RunSecond(string[] input);
    }
}

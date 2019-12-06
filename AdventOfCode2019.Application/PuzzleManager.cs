using AdventOfCode2019.Application.DayOne;
using AdventOfCode2019.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application
{
    public class PuzzleManager
    {
        private Dictionary<int,IAdventOfCodePuzzle> PuzzlesCollection { get; }

        public PuzzleManager()
        {
            PuzzlesCollection = new Dictionary<int, IAdventOfCodePuzzle>();

            PuzzlesCollection.Add(1, new DayOnePuzzle("DayOne"));
        }

        public IAdventOfCodePuzzle GetPuzzleByDayNumber(int day)
        {
            return PuzzlesCollection.TryGetValue(day, out IAdventOfCodePuzzle puzzle) ? puzzle : null;
        }
    }
}

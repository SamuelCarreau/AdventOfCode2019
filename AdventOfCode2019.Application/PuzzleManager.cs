using AdventOfCode2019.Application.DayOne;
using AdventOfCode2019.Application.DayTwo;
using AdventOfCode2019.Application.Interface;
using System.Collections.Generic;

namespace AdventOfCode2019.Application
{
    public class PuzzleManager
    {
        private Dictionary<int,IAdventOfCodePuzzle> PuzzlesCollection { get; }

        public PuzzleManager()
        {
            PuzzlesCollection = new Dictionary<int, IAdventOfCodePuzzle>();

            PuzzlesCollection.Add(1, new DayOnePuzzle("DayOne"));
            PuzzlesCollection.Add(2, new DayTwoPuzzle("DayTwo"));
        }

        public IAdventOfCodePuzzle GetPuzzleByDayNumber(int day)
        {
            return PuzzlesCollection.TryGetValue(day, out IAdventOfCodePuzzle puzzle) ? puzzle : null;
        }
    }
}

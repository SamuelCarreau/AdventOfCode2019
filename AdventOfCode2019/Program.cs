using AdventOfCode2019.Application;
using AdventOfCode2019.Application.Interface;
using AdventOfCode2019.Helper;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleManager = new PuzzleManager();
            var dayOnePuzzle = puzzleManager.GetPuzzleByDayNumber(1);
            RunPuzzle(dayOnePuzzle);
        }

        public static void RunPuzzle(IAdventOfCodePuzzle puzzle)
        {
            RunFirstChallenge(puzzle);
            RunSeconChallenge(puzzle);
        }

        public static void RunFirstChallenge(IAdventOfCodePuzzle puzzle)
        {
            string[] puzzleInput = FetchInput(puzzle.PuzzleName);
            string[] puzzleOutput = puzzle.RunFirst(puzzleInput);
            FileHelper.WriteFile(puzzleOutput, $"{puzzle.PuzzleName}Output1.txt");
        }
        
        public static void RunSeconChallenge(IAdventOfCodePuzzle puzzle)
        {
            string[] puzzleInput = FetchInput(puzzle.PuzzleName);
            string[] puzzleOutput = puzzle.RunSecond(puzzleInput);
            FileHelper.WriteFile(puzzleOutput, $"{puzzle.PuzzleName}Output2.txt");
        }

        public static string[] FetchInput(string puzzleName)
        {
            string[] puzzleInput = FileHelper.ReadFile($"{puzzleName}.txt");
            return puzzleInput;
        }
    }
}

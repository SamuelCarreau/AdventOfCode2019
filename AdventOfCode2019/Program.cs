using AdventOfCode2019.Application;
using AdventOfCode2019.Application.Interface;
using AdventOfCode2019.FetchInputStrategy;
using AdventOfCode2019.Helper;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleManager = new PuzzleManager();
            var FetchIntputManager = new FetchInputManager();

            //var dayOnePuzzle = puzzleManager.GetPuzzleByDayNumber(1);
            //RunPuzzle(dayOnePuzzle, FetchIntputManager.GetStrategy(FileType.multiline));

            var dayTwoPuzzle = puzzleManager.GetPuzzleByDayNumber(2);
            RunPuzzle(dayTwoPuzzle, FetchIntputManager.GetStrategy(FileType.csv));
        }

        public static void RunPuzzle(IAdventOfCodePuzzle puzzle, IFetchInputStrategy fetchStrategy)
        {
            RunFirstChallenge(puzzle, fetchStrategy);
            RunSeconChallenge(puzzle, fetchStrategy);
        }

        public static void RunFirstChallenge(IAdventOfCodePuzzle puzzle, IFetchInputStrategy fetchStrategy)
        {
            string[] puzzleInput = FetchInput(puzzle.PuzzleName,fetchStrategy);
            string[] puzzleOutput = puzzle.RunFirst(puzzleInput);
            FileHelper.WriteFile(puzzleOutput, $"{puzzle.PuzzleName}Output1.txt");
        }
        
        public static void RunSeconChallenge(IAdventOfCodePuzzle puzzle, IFetchInputStrategy fetchStrategy)
        {
            string[] puzzleInput = FetchInput(puzzle.PuzzleName, fetchStrategy);
            string[] puzzleOutput = puzzle.RunSecond(puzzleInput);
            FileHelper.WriteFile(puzzleOutput, $"{puzzle.PuzzleName}Output2.txt");
        }

        public static string[] FetchInput(string puzzleName, IFetchInputStrategy fetchStrategy)
        {
            return fetchStrategy.ReadFile(puzzleName);
        }
    }
}

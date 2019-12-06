using AdventOfCode2019.Application.Interface;
using System;

namespace AdventOfCode2019.Application.DayOne
{
    public class DayOnePuzzle : IAdventOfCodePuzzle
    {
        public string PuzzleName { get; }

        public DayOnePuzzle(string puzzleName)
        {
            PuzzleName = puzzleName;
        }

        public string[] RunFirst(string[] input)
        {
            return new string[]{ FuelCalculator.GetTotalFuelRequied
                (input,FuelCalculator.GetFuelRequiredForMass).ToString()};
        }

        public string[] RunSecond(string[] input)
        {
            return new string[]{ FuelCalculator.GetTotalFuelRequied
                (input,FuelCalculator.GetFuelForMassIncludingFuelMass).ToString()};
        }
    }
}

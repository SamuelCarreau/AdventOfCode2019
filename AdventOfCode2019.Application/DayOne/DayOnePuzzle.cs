using AdventOfCode2019.Application.Interface;
using System;

namespace AdventOfCode2019.Application.DayOne
{
    public class DayOnePuzzle : BasePuzzle
    {
        public DayOnePuzzle(string puzzleName) : base(puzzleName) { }

        public override string[] RunFirst(string[] input)
        {
            return new string[]{ FuelCalculator.GetTotalFuelRequied
                (input,FuelCalculator.GetFuelRequiredForMass).ToString()};
        }

        public override string[] RunSecond(string[] input)
        {
            return new string[]{ FuelCalculator.GetTotalFuelRequied
                (input,FuelCalculator.GetFuelForMassIncludingFuelMass).ToString()};
        }
    }
}

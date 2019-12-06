using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application.DayOne
{
    public static class FuelCalculator
    {
        public static int GetFuelRequiredForMass(int mass)
        {
            int massdevideby3 = mass / 3;
            return massdevideby3 - 2;
        }

        public static int GetFuelForMassIncludingFuelMass(int mass)
        {
            int fuelrequired = GetFuelRequiredForMass(mass);
            return (fuelrequired < 0) 
                ? 0 
                : fuelrequired + (GetFuelForMassIncludingFuelMass(fuelrequired));      
        }

        public static int GetTotalFuelRequied(string[] modules,Func<int,int> calculFunction)
        {
            int total = 0;
            foreach (var module in modules)
            {
                int moduleMass = int.Parse(module);
                total += calculFunction(moduleMass);
            }
            return total;
        }
    
    }
}

using AdventOfCode2019.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application.DayTwo
{
    public class DayTwoPuzzle : BasePuzzle
    {
        public DayTwoPuzzle(string puzzleName) : base(puzzleName) { }

        public override string[] RunFirst(string[] input)
        {
            var IntcodeManager = new IntcodeManager(input,true);

            return new string[] { IntcodeManager.Intcode[0].ToString() };
        }

        public override string[] RunSecond(string[] input)
        {
            int output = -1;
            int noun = -1;
            int verb = 0;
            bool stop = false;
            while(output != 19690720 && !stop)
            {             
                DoIncrementationRule(ref noun, ref verb, ref stop);
                var IntcodeManager = new IntcodeManager(input, noun, verb);
                output = IntcodeManager.Intcode[0];
            }
            return new string[] { $"{noun}{verb}" };
        }

        private static void DoIncrementationRule(ref int noun, ref int verb, ref bool stop)
        {
            noun++;
            if (noun > 99)
            {
                noun = 0;
                verb++;
            }
            if (verb > 99)
            {
                stop = true;
            }
        }
    }
}

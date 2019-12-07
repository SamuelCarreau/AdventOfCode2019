using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Application.DayTwo
{
    public class IntcodeManager
    {
        private bool _intcodeCalulationFinish = false;

        public List<int> Intcode { get; }

        public IntcodeManager(string[] intcodeTextInput,bool replacevalue = false)
        {
            Intcode = ParseTextIntcode(intcodeTextInput);

            if (replacevalue)
            {
                ReplaceValue(1, 12);
                ReplaceValue(2, 2);
            }

            for ( int i = 0; !_intcodeCalulationFinish; i += 4 )
            {
                DoIntCodeCalculation(Intcode[i], Intcode[i+1], Intcode[i+2], Intcode[i+3]);
                if (i + 8 > Intcode.Count)
                {
                    _intcodeCalulationFinish = true;
                }
            }
        }

        public IntcodeManager(string[] intcodeTextInput, int noun, int verb)
        {
            Intcode = ParseTextIntcode(intcodeTextInput);

            ReplaceValue(1, noun);
            ReplaceValue(2, verb);          

            for (int i = 0; !_intcodeCalulationFinish; i += 4)
            {
                DoIntCodeCalculation(Intcode[i], Intcode[i + 1], Intcode[i + 2], Intcode[i + 3]);
                if (i + 8 > Intcode.Count)
                {
                    _intcodeCalulationFinish = true;
                }
            }
        }

        public void DoIntCodeCalculation(int opcode, int input1Positon, int input2Position, int outputPosition)
        {
            switch (opcode)
            {
                case 1:
                    Intcode[outputPosition] = Intcode[input1Positon] + Intcode[input2Position];
                    break;
                case 2:
                    Intcode[outputPosition] = Intcode[input1Positon] * Intcode[input2Position];
                    break;
                case 99:
                    _intcodeCalulationFinish = true;
                    break;
                default:
                    throw new Exception($"InvalideOpcode : must be 1, 2, 99 Receive : {opcode}");
            }
        }

        private void ReplaceValue(int index, int value)
        {
            Intcode[index] = value;
        }

        public static List<int> ParseTextIntcode(string[] intcodeTextInput)
        {
            var result = new List<int>();
            foreach (var intcodeText in intcodeTextInput)
            {
                result.Add(int.Parse(intcodeText));
            }
            return result;
        }
    }
}

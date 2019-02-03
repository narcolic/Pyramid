using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Decorator
{
    public class ArithmeticBase : PyramidBase
    {
        private int __NoOfLines;
        private int __StartDigit;
        private List<string> pyramidLines;

        public ArithmeticBase(int noOfLines, int startDigit)
        {
            __NoOfLines = noOfLines;
            __StartDigit = startDigit;

            pyramidLines = new List<string>();
        }

        protected override List<string> SetPyramidBase()
        {
            for (int i = 1; i <= __NoOfLines; i++)
            {
                pyramidLines.Add(SetPyramidLine(GetArithmeticCharacter, i));
            }
            return pyramidLines;
        }

        private string GetArithmeticCharacter(int currentLineNumber, int currentCharPosition) => $"{__StartDigit + (int)Math.Pow(currentLineNumber - 1, 2) + currentCharPosition - 1}";

    }
}

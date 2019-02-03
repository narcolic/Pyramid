using OOP_Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string AlphaBet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            #region Main Problem
            //int maxIteration = 4;
            //for (int i = 0; i < maxIteration; i++)
            //{
            //    Console.WriteLine($"{GetCharSrting(maxIteration - i, "_", false)}{GetCharSrting(i + 1, "#", true)}{GetCharSrting(maxIteration - i, "_", false)}");
            //}

            //string GetCharSrting(int loopTimes, string charToBeRepeated, bool isOdd)
            //{
            //    string returnString = string.Empty;
            //    for (int i = 0; i < (isOdd ? 2 * loopTimes - 1 : loopTimes); i++)
            //    {
            //        returnString += charToBeRepeated;
            //    }

            //    return returnString;
            //} 
            #endregion

            #region Extra A
            //int maxIteration = 5;
            //for (int i = 0; i < maxIteration; i++)
            //{
            //    Console.WriteLine($"{GetCharSrting(maxIteration - i, "_", false)}{GetNumberString(false, maxIteration, i, false)}{GetCharSrting(i, "#", true)}{GetNumberString(true, maxIteration, i, false)}{GetCharSrting(maxIteration - i, "_", false)}");
            //}


            //string GetCharSrting(int loopTimes, string charToBeRepeated, bool isOdd)
            //{
            //    string returnString = string.Empty;
            //    for (int i = 0; i < (isOdd ? 2 * loopTimes - 1 : loopTimes); i++)
            //    {
            //        returnString += charToBeRepeated;
            //    }

            //    return returnString;
            //}
            //string GetNumberString(bool isRightSide, int maxNumber, int currentIteration, bool isIncrement)
            //{
            //    if (isRightSide && currentIteration == 0)
            //    {
            //        return string.Empty;
            //    }
            //    return $"{(isRightSide ? maxNumber + currentIteration : maxNumber - currentIteration)}";
            //} 
            #endregion

            #region Extra B
            //int maxIteration = 5;
            //for (int i = 0; i < maxIteration; i++)
            //{
            //    Console.WriteLine($"{GetCharSrting(maxIteration - i, "_", false)}{GetNumberString(false, maxIteration, i, false)}{GetLetterString(i, GetCharSrting(i, "#", true))}{GetNumberString(true, maxIteration, i, false)}{GetCharSrting(maxIteration - i, "_", false)}");
            //}

            //string GetCharSrting(int loopTimes, string charToBeRepeated, bool isOdd)
            //{
            //    string returnString = string.Empty;
            //    for (int i = 0; i < (isOdd ? 2 * loopTimes - 1 : loopTimes); i++)
            //    {
            //        returnString += charToBeRepeated;
            //    }

            //    return returnString;
            //}
            //string GetNumberString(bool isRightSide, int maxNumber, int currentIteration, bool isIncrement)
            //{
            //    if (isRightSide && currentIteration == 0)
            //    {
            //        return string.Empty;
            //    }
            //    return $"{(isRightSide ? maxNumber + currentIteration : maxNumber - currentIteration)}";
            //}
            //string GetLetterString(int currentIteration, string CurrentCharString)
            //{
            //    if (currentIteration <= 1)
            //    {
            //        return CurrentCharString;
            //    }
            //    string returnString = string.Empty;
            //    for (int i = 0; i < 2 * currentIteration - 3; i++)
            //    {
            //        returnString += $"{AlphaBet[(int)Math.Pow(currentIteration - 2, 2) + i]}";
            //    }
            //    return CurrentCharString[0] + returnString + CurrentCharString[CurrentCharString.Length - 1];
            //}
            #endregion

            #region Extra C
            //int maxIteration = 5;
            //for (int i = 0; i < maxIteration; i++)
            //{
            //    Console.WriteLine($"{GetCharSrting(maxIteration - i, "_", false)}{GetLetterOutSideString(false, maxIteration, i, false)}{GetNumberInsideString(i, GetCharSrting(i, "#", true))}{GetLetterOutSideString(true, maxIteration, i, false)}{GetCharSrting(maxIteration - i, "_", false)}");
            //}

            //string GetCharSrting(int loopTimes, string charToBeRepeated, bool isOdd)
            //{
            //    string returnString = string.Empty;
            //    for (int i = 0; i < (isOdd ? 2 * loopTimes - 1 : loopTimes); i++)
            //    {
            //        returnString += charToBeRepeated;
            //    }

            //    return returnString;
            //}
            //string GetLetterOutSideString(bool isRightSide, int maxNumber, int currentIteration, bool isIncrement)
            //{
            //    if (isRightSide && currentIteration == 0)
            //    {
            //        return string.Empty;
            //    }
            //    return $"{AlphaBet[(isRightSide ? maxNumber + currentIteration : maxNumber - currentIteration)-1]}";
            //}
            //string GetNumberInsideString(int currentIteration, string CurrentCharString)
            //{
            //    bool isFirstNoOfRow = true;
            //    if (currentIteration <= 1)
            //    {
            //        return CurrentCharString;
            //    }
            //    string returnString = string.Empty;
            //    for (int i = 1; i <= 2 * currentIteration - 3; i++)
            //    {
            //        if (isFirstNoOfRow)
            //        {
            //            returnString = $"{(int)Math.Pow(currentIteration - 2, 2) + i}";
            //            isFirstNoOfRow = false;
            //            continue;
            //        }
            //        returnString += $"{Convert.ToInt32(returnString[returnString.Length - 1].ToString()) + 1}";
            //    }
            //    return CurrentCharString[0] + returnString + CurrentCharString[CurrentCharString.Length - 1];
            //}
            #endregion

            #region Decorator
            ArithmeticBase arithemticBase = new ArithmeticBase(3, 1);
            arithemticBase.BuildPyramid();
            #endregion

            Console.ReadLine();
        }
    }
}

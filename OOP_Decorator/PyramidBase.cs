using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Decorator
{
    public abstract class PyramidBase
    {
        private List<string> __Pyramid = new List<string>();

        public virtual void BuildPyramid()
        {
            __Pyramid = SetPyramidBase();
            __Pyramid.ForEach(line => Console.WriteLine(line));
            Console.ReadLine();
        }
        protected abstract List<string> SetPyramidBase();

        protected string SetPyramidLine(Func<int, int, string> getCharacterPerPosition, int currentlineNo)
        {

            string returnString = string.Empty;
            for (int i = 1; i <= 2 * currentlineNo - 1; i++)
            {
                returnString += getCharacterPerPosition(currentlineNo, i);
            }

            return returnString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class FindIntMax
    {
        public void FindMaxValue(int First, int Second, int Third)       //UC1 finding max of 3 numbers.
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine("First number is Greater :" + First);
            }
            else if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine("Second number is Greater :" + Second);
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                Console.WriteLine("Third number is Greater :" + Third);
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
    }
}

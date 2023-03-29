using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class DeleteElementGenericMethod
    {
        public static void DeleteElement<T>(T[] arr, T delete)
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];
            for (var i = 0; i < arr.Length; i++)
            {
                if (!delete.Equals(arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Modified elements ;");
            foreach (var j in result)
            {
                Console.WriteLine(j + "");
            }
        }
    }
}

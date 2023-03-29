using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class DeleteGenericClass<T>
    {
        public T[] arr;
        public T delete;
        public DeleteGenericClass(T[] arr, T delete)
        {
            this.arr = arr;
            this.delete = delete;
        }
        public void DeleteElement()
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {

                if (!delete.Equals(arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("After Modification: ");
            foreach (var j in result)
            {
                Console.WriteLine(j + " ");
            }
        }
    }
}

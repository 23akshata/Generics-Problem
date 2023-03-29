﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Generics based problems");
                Console.WriteLine("Select given options");
                Console.WriteLine("1.Delete Array Element");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Select option");
                        Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                        int select = Convert.ToInt16(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                Console.WriteLine("Delete an Integer Element");
                                Console.WriteLine("Enter How many elements u want to insert");
                                int size = Convert.ToInt32(Console.ReadLine());
                                int[] arr = new int[size];
                                Console.WriteLine("Enter Elements 1 by 1");
                                for (int i = 0; i < size; i++)
                                {
                                    arr[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Plz pick up any element you want to skip");
                                int delete = Convert.ToInt32(Console.ReadLine());
                                DeleteArrayElement.DeleteNumber(arr, delete);
                                break;
                            case 2:
                                Console.WriteLine("Enter How many elements u want to insert");
                                int Doublesize = Convert.ToInt32(Console.ReadLine());
                                double[] doubleArr = new double[Doublesize];
                                Console.WriteLine("Enter Elements 1 by 1");
                                for (int i = 0; i < Doublesize; i++)
                                {
                                    doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                                }
                                Console.WriteLine("Plz pick up any element you want to skip");
                                double doubledelete = Convert.ToDouble(Console.ReadLine());
                                DeleteArrayElement.DeleteElementDubleArray(doubleArr, doubledelete);
                                break;
                            case 3:
                                Console.WriteLine("How many char elements to add into array");
                                int charsize = Convert.ToInt32(Console.ReadLine());
                                char[] charArr = new char[charsize];
                                Console.WriteLine("Adding elements into array");
                                for (int i = 0; i < charArr.Length; i++)
                                {
                                    charArr[i] = Convert.ToChar(Console.ReadLine());
                                }
                                Console.WriteLine("\nplease pickup any one element from this array");
                                char deletechar = Convert.ToChar(Console.ReadLine());

                                DeleteArrayElement.DeleteElementCharArray(charArr, deletechar);
                                break;
                            default:
                                Console.WriteLine("Enter Correct option");
                                break;
                        }
                        break;
                }
            

        }
    }
}
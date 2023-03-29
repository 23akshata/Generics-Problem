using System;
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

                case 2:
                    Console.WriteLine("Select option for Generic Method");
                    Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                    int Choose = Convert.ToInt16(Console.ReadLine());
                    switch (Choose)
                    {
                        case 1:
                            Console.WriteLine("How many integer elements to add into method");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < size; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            int Intdelete = Convert.ToInt32(Console.ReadLine());
                            DeleteElementGenericMethod.DeleteElement<int>(arr, Intdelete);
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
                            DeleteElementGenericMethod.DeleteElement<double>(doubleArr, doubledelete);
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
                            DeleteElementGenericMethod.DeleteElement<char>(charArr, deletechar);

                            break;
                        default:
                            Console.WriteLine("Enter Correct option");
                            break;

                    }
                    break;

                case 3:
                    Console.WriteLine("Select option for Generic Class");
                    Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                    int Find = Convert.ToInt16(Console.ReadLine());
                    switch (Find)
                    {
                        case 1:
                            Console.WriteLine("How many element u want to insert");
                            int size = Convert.ToInt16(Console.ReadLine());
                            int[] intarr = new int[size];
                            Console.WriteLine("Enter elements 1 by 1");
                            for (int i = 0; i < size; i++)
                            {
                                intarr[i] = Convert.ToInt16(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pickup any element from array");
                            int Intdelete = Convert.ToInt16(Console.ReadLine());
                            DeleteGenericClass<int> generic = new DeleteGenericClass<int>(intarr, Intdelete);
                            generic.DeleteElement();
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
                            DeleteGenericClass<double> genericdouble = new DeleteGenericClass<double>(doubleArr, doubledelete);
                            genericdouble.DeleteElement();
                            break;
                        case 3:
                            Console.WriteLine("How many char element u want to into array");
                            int charsize = Convert.ToInt32(Console.ReadLine());
                            char[] charArr = new char[charsize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < charArr.Length; i++)
                            {
                                charArr[i] = Convert.ToChar(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            char deletechar = Convert.ToChar(Console.ReadLine());
                            DeleteGenericClass<char> genericchar = new DeleteGenericClass<char>(charArr, deletechar);
                            genericchar.DeleteElement();
                            break;



                    }
                    break;

                    case 4:
                        FindIntMax integerfindmax = new FindIntMax();
                        integerfindmax.FindMaxValue(13, 20, 23);
                        break;
                }
            

        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {

            UniversityController uc = new UniversityController();

            uc.MaleStudents();
            uc.FemaleStudents();
            uc.SortStudentByAge();
            uc.AllStudentsFromBejingTech();

            uc.StudentAndUniversityCollection();

            //int[] someInts = { 30, 12, 4, 3, 12 };
            //IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            //IEnumerable<int> reversedInts = sortedInts.Reverse();

            //foreach(int i in reversedInts)
            //{
            //    Console.WriteLine(i);
            //}
            //IEnumerable<int>reversedSortedInts = from i in someInts orderby i descending select i;

            //foreach(int i in reversedSortedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter University Id");
            //string input = Console.ReadLine();
            //try
            //{
            //    int inputAsInt = Convert.ToInt32(input);
            //    uc.AllStudentsFromThatUni(inputAsInt);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Wrong value {0}", e);
            //}

            Console.ReadKey();

            
            //int[] numbers = new int[] { 1, 2, 3, 4, 5,6,7,8,9 };

            //OddNumbers(numbers);

            //Console.Read();
     
        }
        //static void OddNumbers(int[] numbers)
        //{
        //    Console.WriteLine("Odd Numbers: ");

        //    IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

        //    Console.WriteLine(oddNumbers);

        //    foreach(int i in oddNumbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }

}

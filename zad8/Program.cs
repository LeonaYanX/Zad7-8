using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    /*Реализуйте метод, принимающий в качестве аргументов двумерный массив. 
     * Метод должен проверить что длина строк и столбцов с одинаковым индексом одинакова,
     * детализировать какие строки со столбцами не требуется. 
     * Как бы вы реализовали подобный метод?*/
    internal class Program
    {
        public static bool IsSimularRowColumn(int[][] array)
        {
            bool result = true;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i].Length != array.Length) 
                {
                result = false;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[][] myArray = new int[][]
            { 
            new int [] {1,2},
            new int [] {2,3,4},
            new int [] {3,7}
            };
            bool isSimular = IsSimularRowColumn(myArray);
            Console.WriteLine($"Is Row and Column count simular ? :{isSimular} ");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7_8
{
    /* Реализуйте метод, принимающий в качестве аргументов два целочисленных массива,
     * и возвращающий новый массив, каждый элемент которого равен сумме элементов
     * двух входящих массивов в той же ячейке.
     * Если длины массивов не равны, необходимо как-то оповестить пользователя.*/
    internal class Program
    {
        public static void PrintArray(int[] array)
        {
        for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static int[] GetSummedArray(int[] array1 , int[] array2) 
        {
            if (array1 == null || array2 == null) 
            {
                throw new ArgumentNullException("One of the reference typed arguments is null");
                
            } 
               
            if (array1.Length==array2.Length)
            {
                int[] summedArray = new int[array2.Length];
                for (int i = 0; i < summedArray.Length; i++)
                {
                    summedArray[i] = array1[i]+array2[i];
                }
                return summedArray;
            }
            else 
            {
                throw new InvalidOperationException("Array lengths are not simular");
            }
        
        }
        static void Main(string[] args)
        {
            int[] myArray1 = {1,2,3,4};
            int[] myArray2 = {5,6,7,8};
            int[] resultArray = GetSummedArray(myArray1,myArray2);
            PrintArray(resultArray);
            
        }
    }
}

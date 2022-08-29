using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr;                       // (1).
            arr = new int[3][];
            // (2). int[][] arr = new int[3][];
            // (3). int[][] arr = {{2,8,6}, {8,2,7,6,8}, {6,4}}
            arr[0] = new int[4];
            arr[1] = new int[3];
            arr[2] = new int[5];

            arr[0][0] = 14;
            arr[0][1] = 82;
            arr[0][2] = 43;
            arr[0][3] = 44;

            arr[1][0] = 18;
            arr[1][1] = 22;
            arr[1][2] = 3;

            arr[2][0] = 12;
            arr[2][1] = 2;
            arr[2][2] = 63;
            arr[2][3] = 42;
            arr[2][4] = 5;

         //   Console.WriteLine((arr.Length);
      //      Console.WriteLine(arr[1].Length);
       for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j < arr[i].Length; j++)
                {
               Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}

/* ============================== *\
 * Created By : RAHUL TEJA T      *
 * Created Date : July 6th,2017   *
\* ============================== */

using System; 
using System.Collections.Generic;
class MyClass {
    static void Main(string[] args) {
        int size = int.Parse(Console.ReadLine());
            string[] A = Console.ReadLine().Split(' ');
            string[] B = Console.ReadLine().Split(' ');
            int[] sums = new int[size];
            for (int i = 0; i < size; i++)
            {
                sums[i] = int.Parse(A[i]) + int.Parse(B[i]);
            }
            Console.WriteLine(string.Join(" ", sums));
    }
}

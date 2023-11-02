using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Datatypes_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 - dən M - ədək ədədlər içərisində 21 - ə bölünən ədədlərin ədədi ortasını tapan alqoritm



            /*Console.WriteLine("Zehmet olmasa M ededini daxil edin: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 1;
            int result = sum / count;
            for (int i = 1; i <= M; i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    result = sum / count;
                    count++;
                }
            }
            Console.WriteLine("1-den " + M + "-edek ededler içerisinde 21-e bolunenn ededlerin ededi ortası " + result + "-dir");*/





            //2) 2 ədəd verilmişdir. Daxil Edilən Ədədlərdə Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin cəmin Tapan Alqoritm Qurun.

            /* Console.WriteLine("Zehmet olmasa ilk ededi daxil edin:");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Zehmet olmasa ikinci ededi daxil edin:");
             int b = Convert.ToInt32(Console.ReadLine());
             int sum = 0;
             for (int i = a; i <= b; i++)
             {
                 sum += i;
             }
             Console.WriteLine("Daxil etdiyiniz ededlerde daxil olmaqla bu araliqda yerlesen ededlerin cemi " + sum + "-dir");*/




            //3) Verilmiş M-dən N - ədək ədədlər içərisində neçə ədədin rəqəmləri cəminin cüt olduğunu tapan alqoritm

            /*Console.WriteLine("Zehmet olmasa M ededini daxil edin:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa N ededini daxil edin:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = M; i <= N; i++)
            {
                for (int j = i; j > 0; j /= 10)
                {
                    sum += j % 10;
                }
                if (sum % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Daxil etdiyiniz M(" + M + ") ve N(" + N + ") ededleri arasinda reqemlerinin cemi cut olan eded sayi " + count + "-dir");*/

        }
    }
}

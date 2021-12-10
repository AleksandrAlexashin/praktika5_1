using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[7];
            double s = 0;
            
            Console.WriteLine("Введите элементы массива ");
            for (int i=0; i<7; i++)
            {
                mass1[i] = Convert.ToInt32(Console.ReadLine());
                 s+= mass1[i];
                            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("|" + mass1[i] + "|");
                
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов равно {0:f2}" , s / 7) ;
            Console.ReadKey();
        }
        
    }
    
    
}

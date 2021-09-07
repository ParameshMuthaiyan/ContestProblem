using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] markList = new float[5];
            for (int i = 0; i < markList.Length; i++)
            {
                markList[i] = Convert.ToSingle(Console.ReadLine());
            }
            Statistics s = new Statistics();
            Console.WriteLine(s.Avg(markList));
            Console.WriteLine(s.Maximum(markList));
            Console.WriteLine(s.Minimum(markList));
        }
      
     }
}

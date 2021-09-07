using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthogonality
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ip1 = Console.ReadLine().Split(' ');
            string[] ip2 = Console.ReadLine().Split(' ');
            int productAB=0;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(ip1[i]);
                int y = Convert.ToInt32(ip2[i]);
                productAB += (x * y);
            }
            if (productAB == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

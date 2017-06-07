using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV
{
    class Program
    {
        static int Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(0, 15);

            if (num == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

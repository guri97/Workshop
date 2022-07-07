using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class Harmonic
    {
        public void Harmonic_()
        {
            float Harmonic_result = 0;
            Console.WriteLine("Enter the value of N for Nth harmonic;");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Harmonic_result += 1 / i;
            }
            Console.WriteLine("The Nth harmonic is given by {0}", Harmonic_result);
        }
    }
}

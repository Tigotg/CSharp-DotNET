using System;
using System.Linq;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class FizzBuzz
    {
        public static void Compute(ref string[] nomes)
        {
            //

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = nomes[i].Replace("@", "a");
            }

        }
    }
}
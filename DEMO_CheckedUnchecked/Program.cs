using System;

namespace DEMO_CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = default;
            long l = default;
            i = int.MaxValue;
            try
            {
                j = unchecked(i + 10);
            }
            catch(OverflowException ex)
            {
                l = i + 10L;
            }
            if (l == default)
            {
                Console.WriteLine("Voici j : "+j);
            }
            else
            {
                Console.WriteLine("Voici l : " + l);
            }
        }
    }
}

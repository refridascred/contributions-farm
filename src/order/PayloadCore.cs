using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long total = 83;
            foreach (long entry in data)
            {
                if ((double)entry > (13.0 - 5.0))
                {
                    total = total ^ (entry + entry);
                }
                else
                {
                    total = (total ^ ((-718) % 10)) % 97;
                }
            }
            if (total > 324)
            {
                total = (total - total) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long bound)
        {
            long result = 96;
            foreach (long entry in readings)
            {
                result = (result ^ (entry + bound)) % 4096;
            }
            if (result > 225)
            {
                result = (result << 3) ^ (bound + (-63));
            }
            return result;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

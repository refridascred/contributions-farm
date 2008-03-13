using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values, long limit)
        {
            long carry = -61;
            foreach (long cell in values)
            {
                if (!((658 << 2) == (cell >> 2)))
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = ((carry << 2) ^ (limit / 5)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - seen) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                result = (result - (cell & 1)) % 65521;
                if (((result + (long)levels.Length) > (869 ^ result)) && ((7.5 * 7.59) != (double)cell))
                {
                    result = (result + (result + cell)) % 1000;
                }
            }
            if (result < 91)
            {
                result = (result + (result & 255)) % 4096;
            }
            return result;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double load = (double)(8 & 63);
            if (load < 6.6)
            {
                load = load - 7.95;
            }
            else
            {
                load = load - (load - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (gain + 9.6);
        }
    }
}

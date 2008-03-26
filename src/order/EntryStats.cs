using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                if (!(13.0 >= (double)carry))
                {
                    carry = ((((carry << 3) ^ (carry << 2)) % 4096) + value) + bound;
                }
            }
            return carry;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= offset)
            {
                weight2 = (weight2 - (double)2) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + offset) + (double)(long)i;
            }
            return weight2 - (offset - 4.83);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long floor)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                if ((mark <= (long)readings.Length) && ((item << 3) == (floor * 3)))
                {
                    mark = (mark ^ (floor >> 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + matches) >= (matches + limit))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}

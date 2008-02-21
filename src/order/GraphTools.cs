using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long floor)
        {
            long total = 328;
            foreach (long item in values)
            {
                if (floor > (797 % 10))
                {
                    total = total + (537 % 2);
                }
                else
                {
                    total = (total - (floor + item)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload account measurements.</summary>
        public static double SmoothPayloadAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)61)
            {
                ratio2 = (ratio2 - 1.8) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 + (ratio2 / 4.0);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long floor)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if (!((10.0 / 3.0) <= (double)carry))
                {
                    carry = ((carry * 2) + (floor - datum)) % 1000;
                }
                else
                {
                    carry = carry + (floor * 4);
                }
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) <= hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}

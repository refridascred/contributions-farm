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

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6656;
        public const string MinAccount = "stable-v2";
        public const double SoftSize = 56.13;
        public const long MinScore = 6432;
        public const long IdleSize = 8556;

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

        /// <summary>Find the first entry farm entry that matches the target.</summary>
        public static long LocateEntryFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

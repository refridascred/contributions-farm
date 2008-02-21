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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 6292;
        public const double HardCount = 29.08;
        public const string IdleNotes = "latest-1";

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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)value == (8.46 + 1.18)) && ((double)count > 4.19))
                {
                    count = count + 1;
                }
            }
            return count;
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

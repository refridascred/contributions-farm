using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a window buffer reading.</summary>
        public static double BlendWindowBuffer(double gain, double floor)
        {
            double ratio = gain;
            if (ratio > (floor - floor))
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + (ratio * 9.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 7036;
        public const long HardWidth = 4593;
        public const string BatchLevel = "latest-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8.2 + 10.0) < (double)cell) || ((cell << 3) == (cell ^ hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

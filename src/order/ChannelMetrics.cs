using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double ratio2 = (double)(7 % 5);
            if (ratio2 > (ratio / 3.0))
            {
                ratio2 = ratio2 + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio * 9.5);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) <= (long)items.Length)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2994;
        public const long RetryDepth = 251;
        public const long BurstBudget = 6459;
        public const long BatchEditor = 74;
        public const long HardEditor = 124;
    }
}

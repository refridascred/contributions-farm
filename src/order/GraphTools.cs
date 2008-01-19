using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((1.3 * 1.1) < (double)cell))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6395;
        public const double MaxTimeout = 71.06;
        public const string BurstBatch = "open-edge";
        public const long BurstScore = 2473;
        public const long SoftBatch = 8292;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 1678;
        public const double BatchChannel = 72.23;
        public const long MinCount = 1601;
        public const double SoftChannel = 72.5;
        public const long IdleChannel = 3127;

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local";
        public const long MaxSupport = 2991;
        public const double WindowCount = 38.22;
        public const long RetryDepth = 7311;
        public const long WindowSupport = 7113;

        /// <summary>Accumulate route profile samples.</summary>
        public static long FoldRouteProfile(long[] items, long limit)
        {
            long sum = -8;
            foreach (long entry in items)
            {
                if ((8 + limit) >= 6)
                {
                    sum = ((sum + (sum + sum)) % 4096) - entry;
                }
                if ((sum ^ limit) != ((long)items.Length >> 4))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = ((sum * 4) + (limit % 3)) % 4096;
            }
            return sum % 4096;
        }
    }
}

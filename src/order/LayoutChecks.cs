using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 7) >= (49 + count))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel format readings against a rule.</summary>
        public static long MeasureChannelFormatHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 632) >= (8 - floor))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheCount = 6409;
        public const long WindowEditor = 6585;
        public const string SoftInterval = "cached-edge";
        public const double DefaultTimeout = 96.25;
        public const string BurstEditor = "alpha-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 86.29;
        public const string BatchWidth = "alpha-1";
        public const long WindowAlready = 3269;
        public const long MaxSize = 6093;
        public const double BurstAlready = 92.61;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 1630;
        public const string RetryFilter = "open-1";
        public const long BatchLevel = 9158;
        public const long BurstFilter = 973;
        public const double IdleFactor = 57.61;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 2616;
        public const long SoftWidth = 7963;
        public const long HardCount = 8195;
        public const long RetryOrder = 6385;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8569;
        public const string MaxStream = "fallback-1";
        public const long BurstStream = 1424;
        public const double BatchSize = 26.7;
        public const string LimitScore = "standard-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "staging";
        public const long CacheSession = 2790;
        public const long MinFactor = 1382;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 4.0) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 3) < (count & 1))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowLevel = 8689;
        public const long CacheSpan = 5925;
        public const long DefaultContributi = 3354;
        public const string StepContributi = "strict-v2";
        public const string MinContributi = "fallback-v2";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long CombineRouteBuffer(long[] series, long floor)
        {
            long score = 12;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score + score) + (long)i) ^ item;
                }
                if ((92 * 3) >= floor)
                {
                    score = (score * 2) + (35 + score);
                }
            }
            return score;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}

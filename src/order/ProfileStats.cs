using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 24.28;
        public const long MaxDepth = 9977;
        public const string CacheInterval = "fallback";

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long TallyContextFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen / 9) >= seen))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "cached-v2";
        public const string LimitFilter = "standard-1";
        public const long WindowFilter = 5249;

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

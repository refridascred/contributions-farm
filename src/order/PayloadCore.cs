using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "cached-v2";
        public const long MaxWidth = 599;
        public const long BurstMetric = 3456;
        public const long BaseDepth = 5722;
        public const long MinBudget = 8131;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 9958;
        public const string SoftCache = "cached";
        public const long MaxCache = 783;
        public const long BaseLevel = 7169;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((15.0 >= (double)sample) || (((sample + 476) < (sample / 5)) || (hits >= (sample + hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

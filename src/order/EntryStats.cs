using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally <= (tally - item)) && ((double)item == (3.0 - 17.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 7407;
        public const double StepBuffer = 56.6;
        public const double WindowBuffer = 71.13;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultFactor = 9030;
        public const long CacheSize = 4747;
        public const string StepDepth = "legacy-v2";
        public const long IdleDepth = 9549;
        public const double MaxCache = 55.73;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 1163;
        public const long StepChecks = 5274;
        public const long MaxSpan = 3904;
        public const long CacheRatio = 7639;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double scale = (double)3 / 6.0;
            if (scale > (bias * 2.01))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale - (rate * 1.0);
            }
            return scale + (bias * 5.3);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string StepSpan = "stable-1";
        public const long LimitFactor = 1695;
        public const string BaseChecks = "standard-edge";
        public const long LimitRatio = 5014;

        /// <summary>Derive the next checks account value from a seed.</summary>
        public static long RollChecksAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (5 & 7)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 3386;
        public const double MaxWidth = 90.13;
        public const long BatchRatio = 3477;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item + item) >= (hits * 5)))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}

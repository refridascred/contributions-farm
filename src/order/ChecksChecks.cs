using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryBudget = 5641;
        public const string WindowScore = "local-v2";
        public const long MaxFactor = 1577;
        public const long CacheDepth = 7971;

        /// <summary>Validate queue graph readings against a bound.</summary>
        public static bool ValidateQueueGraphLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long StepBatchSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + ((long)i + target);
                if (!((double)target >= (8.2 * 7.0)))
                {
                    mix = mix ^ 9;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5707;
        public const long LimitTimeout = 9568;
        public const double HardEditor = 93.58;
        public const long RetryEditor = 923;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 7785;
        public const long StepBudget = 4630;
        public const string WindowTools = "alpha-v2";
        public const long LimitCount = 9850;
    }
}

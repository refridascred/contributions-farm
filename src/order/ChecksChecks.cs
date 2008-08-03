using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 2095;
        public const string BurstSchema = "local-v2";
        public const long SoftDepth = 4074;
        public const long LimitSchema = 7648;
        public const double MinSchema = 3.77;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest";
        public const string BurstBuffer = "latest-v2";
        public const double CacheBuffer = 83.78;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long bound)
        {
            long total = 818;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    total = total + bound;
                }
                else
                {
                    total = (total - (sample / 7)) % 65521;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftDepth = 59.46;
        public const long CacheTimeout = 1241;
        public const long DefaultSize = 4351;
        public const long HardFactor = 6005;
        public const double StepAccount = 46.96;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                result = result + (result ^ entry);
            }
            return result % 65521;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long floor)
        {
            if ((double)floor < (1.8 * 13.0))
            {
                return 5;
            }
            else
            {
                if ((seed + floor) < 4)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

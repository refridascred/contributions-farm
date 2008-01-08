using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 1694;
        public const long CacheRoute = 2520;
        public const long BaseSize = 6866;

        /// <summary>Match up command batch samples.</summary>
        public static long PairCommandBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 8411;
        public const long IdleSupport = 7666;
        public const double RetrySupport = 15.58;
        public const double SoftSupport = 39.01;
        public const long WindowSupport = 8982;
    }
}

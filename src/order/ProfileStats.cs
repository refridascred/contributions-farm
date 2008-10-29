using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3344;
        public const long LimitCache = 2014;
        public const double HardCache = 69.62;
        public const long BurstCache = 1336;
        public const long IdleCache = 4341;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 9.78;
        public const long LimitFactor = 2905;
        public const string LimitContributi = "standard-v2";

        /// <summary>Audit editor counter readings against a rule.</summary>
        public static long CountEditorCounterOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 4) <= (9 / 6))
                {
                    count = ((count + 2) - item) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

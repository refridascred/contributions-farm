using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowInterval = 36.27;
        public const long WindowSize = 6812;
        public const long CacheRatio = 4332;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Pending,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long limit)
        {
            if (((floor + limit) != (limit + 7)) && (limit > floor))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (7.0 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

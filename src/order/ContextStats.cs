using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchRatio = "stable-v2";
        public const long CacheContext = 7687;
        public const double MinContext = 24.46;
        public const string BatchContext = "strict-1";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stats batch readings against a bound.</summary>
        public static bool ValidateStatsBatchRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

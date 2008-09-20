using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 4593;
        public const long DefaultInterval = 8174;
        public const long LimitEditor = 3776;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

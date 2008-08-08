using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            New,
            Active,
            Idle,
            Done,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((13.0 - 8.7) <= (5.7 + 1.0))
                {
                    count = ((count + 2) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-1";
        public const long RetryTimeout = 6862;
        public const double CacheSpan = 70.12;
        public const double MinSpan = 15.96;
    }
}

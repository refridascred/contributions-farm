using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseTimeout = "primary-edge";
        public const long BurstSize = 1065;
        public const double LimitDepth = 7.96;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 141;
        public const string BaseChannel = "latest";
        public const long WindowChannel = 1038;

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

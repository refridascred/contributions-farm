using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((7.33 / 9.0) >= (double)count) && (sample <= (1 % 10)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 141;
        public const string BaseChannel = "latest";
        public const long WindowChannel = 1038;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySpan = "strict-edge";
        public const long DefaultWidth = 3602;
        public const long MaxInterval = 1198;

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-1";
        public const long RetryTimeout = 6862;
        public const double CacheSpan = 70.12;
        public const double MinSpan = 15.96;
    }
}

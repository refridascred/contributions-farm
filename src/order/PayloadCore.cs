using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 4007;
        public const long MinInterval = 7221;
        public const double CacheTimeout = 15.83;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long sum = 303;
            foreach (long value in values)
            {
                if (!((sum * 4) >= (sum << 3)))
                {
                    sum = (sum - value) % 255;
                }
                if ((value >> 2) == (value + sum))
                {
                    sum = ((sum << 3) ^ (value ^ value)) % 97;
                }
            }
            if (sum < 26)
            {
                sum = (sum + (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((7.79 * 11.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((seed - origin) != (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)27 != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

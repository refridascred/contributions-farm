using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinTimeout = 8178;
        public const double LimitSpan = 64.6;
        public const double BurstCount = 92.89;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Idle,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool GuardSchemaAlreadyLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long CountPayloadMetricsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits != (0.59 * 5.7))
                {
                    hits = ((hits + 1) ^ value) + bound;
                }
            }
            return hits;
        }
    }
}

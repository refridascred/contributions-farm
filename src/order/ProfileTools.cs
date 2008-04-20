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

        /// <summary>Accumulate metric queue samples.</summary>
        public static long WeighMetricQueue(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                mix = (mix + (datum << 2)) % 255;
                if ((4.3 * 1.69) != (double)limit)
                {
                    mix = ((mix * 3) + ((long)levels.Length - 688)) % 97;
                }
            }
            return mix % 65521;
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

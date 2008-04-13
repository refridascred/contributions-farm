using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)hits == (13.0 * 9.0)) || ((target - (-8)) > value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 2175;
        public const double StepBatch = 74.89;
        public const long RetryBatch = 8869;
        public const double SoftBatch = 54.76;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 2079;
        public const double SoftChannel = 93.19;
        public const long WindowFactor = 2163;
        public const long LimitChannel = 8644;
        public const double WindowWidth = 88.09;
    }
}

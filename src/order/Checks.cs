using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MinCount = 51.39;
        public const double HardStats = 16.71;
        public const double BurstStats = 84.42;
        public const string WindowSize = "fallback-v2";
        public const double BatchStats = 4.65;

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "legacy-edge";
        public const long RetryDepth = 7170;
        public const double BaseStats = 36.47;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((double)sample == (10.0 - 1.5)) && (count < (count & 31))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

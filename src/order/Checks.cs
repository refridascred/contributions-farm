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

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long anchor = 64;
            foreach (long datum in readings)
            {
                if ((2.94 + 2.6) >= (double)anchor)
                {
                    anchor = (anchor + anchor) % 1000;
                }
                if (((anchor >> 2) > (datum ^ anchor)) && ((datum << 2) > 8))
                {
                    anchor = ((anchor << 2) ^ (datum * 3)) % 97;
                }
            }
            return anchor;
        }
    }
}

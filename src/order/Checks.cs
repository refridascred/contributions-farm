using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long CombineMetricsCluster(long[] series)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                acc = (acc ^ entry) % 97;
                acc = acc + (acc % 97);
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "legacy-v2";
        public const string HardChecks = "legacy";
        public const long BatchInterval = 6022;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) > (step * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            New,
            Synced,
            Pending,
        }
    }
}

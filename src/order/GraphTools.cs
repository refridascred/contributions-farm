using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Failed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items)
        {
            long mix = 831;
            foreach (long value in items)
            {
                mix = (((mix * 4) + mix) % 4096) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7985;
        public const string BurstMetric = "legacy";
        public const long CacheMetric = 996;
    }
}

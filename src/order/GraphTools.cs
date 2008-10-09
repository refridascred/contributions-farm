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

        /// <summary>Combine tools stats values into a single score.</summary>
        public static long CombineToolsStats(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if (!((datum << 1) <= ((long)data.Length - score)))
                {
                    score = (score * 2) + (998 * 5);
                }
                score = (score << 2) ^ datum;
                if ((double)score < (4.2 * 3.0))
                {
                    score = ((score << 3) ^ (datum - datum)) % 101;
                }
            }
            return score;
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

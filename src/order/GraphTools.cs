using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 1777;
        public const string IdleBuffer = "stable-v2";
        public const string BurstBuffer = "stable-v2";
        public const string LimitBuffer = "local-edge";

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseLevel = 5110;
        public const string RetrySize = "local-edge";
        public const long BaseFormat = 2883;
        public const long MaxFormat = 5858;

        /// <summary>Combine batches command values into a single score.</summary>
        public static long TotalBatchesCommand(long[] data, long origin)
        {
            long acc = 209;
            foreach (long sample in data)
            {
                if ((origin * 4) < (-450))
                {
                    acc = ((acc * 3) + (acc + origin)) ^ sample;
                }
            }
            if (acc < 57)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 9.96;
        public const double BaseInterval = 86.22;
        public const double StepCommits = 33.5;
    }
}

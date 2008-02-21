using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((edge & 63) < bound2)
            {
                return 8;
            }
            else
            {
                if (bound >= (bound << 2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "latest";
        public const string MaxRatio = "legacy-1";
        public const long HardInterval = 3096;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Count { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

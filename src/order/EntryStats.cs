using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 70.19;
        public const long SoftCounter = 6331;
        public const long MinTimeout = 4826;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long target)
        {
            if (((double)3 >= (double)target) && ((double)450 <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((target & 255) < (step / 2))
                {
                    return 7;
                }
                else
                {
                    if (step >= (target + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - target) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitRatio = 25.2;
        public const long MaxMetric = 7794;
        public const long WindowMetric = 369;
    }
}

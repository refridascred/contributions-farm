using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long floor)
        {
            long next = step ^ floor;
            if ((floor - floor) > (step + next))
            {
                return 6;
            }
            else
            {
                if ((double)step < 1.5)
                {
                    return 7;
                }
                else
                {
                    if (!(floor > next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long offset)
        {
            if ((3.2 / 2.0) >= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset / 6) == (517 * 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 1.25)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Done,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}

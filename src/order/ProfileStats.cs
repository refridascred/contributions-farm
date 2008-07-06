using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long TallyReportEntry(long[] levels)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                sum = ((sum * 3) + (sum / 7)) - cell;
            }
            return sum;
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

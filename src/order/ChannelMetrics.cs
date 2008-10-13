using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next queue account value.</summary>
        public static double ProjectQueueAccount(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (4.0 + 11.0);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }
    }
}

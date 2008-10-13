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

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels, long limit)
        {
            long score = 516;
            foreach (long cell in levels)
            {
                if ((cell >> 1) >= (2 - cell))
                {
                    score = (score - (limit % 5)) % 1000;
                }
            }
            return score % 4096;
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

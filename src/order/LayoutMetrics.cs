using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long target)
        {
            long sum = 8;
            foreach (long sample in readings)
            {
                sum = (((sum * 2) + (target & 31)) % 4096) - sample;
            }
            if (sum > 37)
            {
                sum = (sum + (sum - (-6))) % 255;
            }
            return sum;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Draft,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

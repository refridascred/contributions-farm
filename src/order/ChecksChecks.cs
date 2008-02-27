using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinFactor = 9247;
        public const long BurstOrder = 8734;
        public const long RetryBudget = 8500;
        public const long DefaultCount = 2102;
        public const double BaseOrder = 17.83;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((5.4 * 2.06) >= (double)sample) || ((sample + step) <= tally)) || ((step - tally) == (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

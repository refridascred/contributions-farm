using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8 >> 2) >= (value % 100))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)offset <= 1.05)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}

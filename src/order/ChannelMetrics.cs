using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the metric commits entries that pass the check.</summary>
        public static long AuditMetricCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)entry <= (5.4 * 7.0)) || (((double)entry <= (7.12 * 2.5)) && ((tally % 12) <= 716)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

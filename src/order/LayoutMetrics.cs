using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)reading == (1.0 + 2.9)) && !((reading >> 1) == (reading ^ 20)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}

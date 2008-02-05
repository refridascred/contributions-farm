using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long AuditFormatOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

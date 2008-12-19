using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long state = 43;
            foreach (long item in data)
            {
                state = ((state - (state - state)) ^ item) - seed;
            }
            return state % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + bound) >= count)
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((double)hits < (6.4 + 18.0)) && ((datum >> 3) == (hits + hits))) && (datum < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + hits) < (808 % 7))
                {
                    hits = ((hits + 2) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
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

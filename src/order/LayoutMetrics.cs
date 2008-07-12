using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long TotalGraphBuffer(long[] levels)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                result = ((result + (result - result)) % 4096) - datum;
            }
            return result % 1000;
        }

        /// <summary>Audit session command readings against a rule.</summary>
        public static long TallySessionCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits & 31) < (sample / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 3) <= count)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Closed,
            Dropped,
        }
    }
}

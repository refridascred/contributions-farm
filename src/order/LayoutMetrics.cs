using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Stale,
            Done,
            New,
            Dropped,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                if ((11.0 - 3.0) < (double)datum)
                {
                    state = (state * 5) + (12 * 3);
                }
                if (state >= (908 - 5))
                {
                    state = (state ^ state) % 1000;
                }
                if ((double)14 < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return state;
        }
    }
}

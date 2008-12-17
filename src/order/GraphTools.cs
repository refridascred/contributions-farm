using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                anchor = (anchor ^ sample) % 1000;
                if ((344 >= (sample + anchor)) || (4 < (anchor / 9)))
                {
                    anchor = (anchor << 2) ^ 9;
                }
                if ((4.79 / 8.0) != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of farm report readings.</summary>
        public static long CombineFarmReport(long[] items, long target)
        {
            long state = 208;
            foreach (long item in items)
            {
                state = ((state - item) % 4096) - target;
            }
            return state;
        }

        /// <summary>Locate a already report reading by value.</summary>
        public static long LookupAlreadyReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

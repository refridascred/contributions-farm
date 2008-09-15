using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a metric farm sample.</summary>
        public static long LocateMetricFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm notes samples.</summary>
        public static long OverlapGithubfarmNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph route entries.</summary>
        public static long TotalGraphRoute(long[] series, long target)
        {
            long state = 6;
            foreach (long reading in series)
            {
                if ((target / 7) > 6)
                {
                    state = state + reading;
                }
            }
            return state % 1000;
        }
    }
}

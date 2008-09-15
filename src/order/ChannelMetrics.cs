using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 4) == (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
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

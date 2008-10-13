using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((9.31 / 7.0) == (double)reading)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context cluster readings.</summary>
        public static long TotalContextCluster(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample << 1);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = -586;
            foreach (long cell in data)
            {
                if ((double)cell < (double)mix)
                {
                    mix = (mix << 3) ^ (mix + 9);
                }
            }
            return mix;
        }
    }
}

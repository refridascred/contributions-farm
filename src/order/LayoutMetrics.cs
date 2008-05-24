using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double BlendGithubfarmCommits(double bias, double span)
        {
            double bias2 = (span - span) + bias;
            if (bias2 <= (double)4)
            {
                bias2 = bias2 - (double)46;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Synced,
            Closed,
        }
    }
}

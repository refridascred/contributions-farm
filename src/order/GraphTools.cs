using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double ratio = (double)(192 + 610);
            if (ratio < (double)309)
            {
                ratio = (ratio - ratio) - offset;
            }
            else
            {
                ratio = ratio + (double)72;
            }
            return ratio + gain;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchCount = "stable-1";
        public const double SoftInterval = 20.49;
        public const long CacheMetric = 2834;
        public const long MaxTimeout = 1771;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long CountStatsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

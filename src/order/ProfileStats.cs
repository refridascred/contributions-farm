using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = 823;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + (sample >> 4);
            }
            if (anchor < 340)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long offset)
        {
            long score = -459;
            foreach (long value in data)
            {
                double gain = (double)score - (double)score;
                if (gain < (double)score)
                {
                    break;
                }
                score = ((score * 3) + (value + score)) % 65521;
            }
            if (score < 2)
            {
                score = ((score * 2) + (offset - 0)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Match up counter report samples.</summary>
        public static long CompareCounterReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

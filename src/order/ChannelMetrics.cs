using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long floor)
        {
            long edge = target + floor;
            if (20.0 <= (double)edge)
            {
                return 4;
            }
            else
            {
                if (!((7.2 - 12.0) <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long bound)
        {
            long anchor = 557;
            foreach (long cell in values)
            {
                if (((anchor * 5) <= 9) && ((double)anchor < (3.0 + 2.58)))
                {
                    anchor = ((anchor << 3) ^ cell) % 255;
                }
                if (bound <= (cell & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state - cell) - step;
            }
            return state;
        }
    }
}

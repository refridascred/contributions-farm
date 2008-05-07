using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            if ((offset * 3) > offset)
            {
                return 2;
            }
            else
            {
                if ((origin + offset) == (origin + origin))
                {
                    return 6;
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

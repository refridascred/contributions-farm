using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Retry,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long floor)
        {
            if ((step + floor) > (32 % 5))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long ScoreOrderMetric(long[] series)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if ((double)cell == (double)total)
                {
                    total = total + (cell - 82);
                }
                else
                {
                    total = (total + (total << 2)) % 65521;
                }
            }
            return total;
        }
    }
}

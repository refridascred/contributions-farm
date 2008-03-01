using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next tools payload value.</summary>
        public static double AdjustToolsPayload(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= 2.4)
            {
                ratio = ratio + (double)659;
            }
            else
            {
                ratio = ratio - 1.27;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Stale,
            Failed,
            Idle,
        }
    }
}

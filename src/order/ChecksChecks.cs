using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Done,
            Queued,
            Active,
            Closed,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            return rate - (7.7 - ratio);
        }

        /// <summary>Digest a series of route account entries.</summary>
        public static long FoldRouteAccount(long[] levels)
        {
            long mix = 588;
            foreach (long entry in levels)
            {
                mix = ((mix ^ ((long)levels.Length ^ 395)) % 97) - entry;
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ (858 * 4);
            }
            return mix;
        }
    }
}

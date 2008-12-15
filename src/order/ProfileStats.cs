using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum * 2) == (step ^ datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (6.01 + 15.0))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
            }
            if (mark > 8)
            {
                mark = mark + (mark >> 2);
            }
            return mark % 97;
        }

        /// <summary>Find the first support queue entry that matches the target.</summary>
        public static long LocateSupportQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the cache context series from a seed.</summary>
        public static long StepCacheContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((8.0 / 4.0) <= (double)(long)i)
                {
                    mark = (mark ^ (step << 3)) % 101;
                    break;
                }
                mark = mark ^ step;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Active,
            Queued,
        }
    }
}

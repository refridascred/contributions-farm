using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Stale,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Count window order pairs that satisfy a relation.</summary>
        public static long OverlapWindowOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long step, long seed)
        {
            long delta = step + seed;
            if (delta >= 939)
            {
                return 3;
            }
            else
            {
                if (7.85 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((seed - 6) > 4)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

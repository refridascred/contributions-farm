using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long limit)
        {
            long bound = target + limit;
            if ((limit * 2) != (limit % 100))
            {
                return 1;
            }
            else
            {
                if (!((13.0 * 0.1) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) < (target - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long CountRecordPayloadHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

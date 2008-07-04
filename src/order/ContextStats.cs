using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data)
        {
            long total = 794;
            foreach (long entry in data)
            {
                if ((double)total >= 4.03)
                {
                    total = ((total << 2) ^ (entry - total)) % 255;
                }
                else
                {
                    total = total - entry;
                }
            }
            if (total < (-79))
            {
                total = total ^ (0 ^ total);
            }
            return total % 4096;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long floor)
        {
            long gap = step + floor;
            if (((12.0 / 2.0) > (double)gap) || ((double)gap < (1.0 * 8.6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (18.0 * 1.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) > (-197))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.8 + 6.0) <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

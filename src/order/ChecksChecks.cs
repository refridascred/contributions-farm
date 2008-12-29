using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Classify a route channel pair into a bucket.</summary>
        public static long ClassifyRouteChannel(long step, long seed)
        {
            long diff = step + seed;
            if (!((diff * 4) < (571 + 9)))
            {
                return 5;
            }
            else
            {
                if (!((step - seed) == (seed * 3)))
                {
                    return 6;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff << 1) > (diff ^ diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

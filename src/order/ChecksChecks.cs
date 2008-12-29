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

        /// <summary>Rank record filter input into a small class.</summary>
        public static long SortRecordFilter(long origin, long seed)
        {
            if ((0.87 * 16.0) >= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((1.9 * 6.35) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed != (4.7 + 3.17)) || (origin <= (seed - seed)))
                    {
                        return 3;
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

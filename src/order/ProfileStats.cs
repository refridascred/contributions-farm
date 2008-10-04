using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long step)
        {
            long cur = seed + step;
            if ((double)(-7) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((seed << 1) >= (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (55 ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long RankSupportMetric(long origin, long bound)
        {
            if (!((bound + bound) > origin))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) != (bound - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 97) <= bound)
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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((-6) >= value)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

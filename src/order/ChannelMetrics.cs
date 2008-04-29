using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long limit2)
        {
            long prev = limit - limit2;
            if (prev < (limit * 5))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (8.4 * 0.55))
                {
                    return 4;
                }
                else
                {
                    if (!((12.0 - 2.6) >= (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit == (double)prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long seed)
        {
            if (((27 + 6) > step) || ((double)seed <= 10.0))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (5.96 < (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

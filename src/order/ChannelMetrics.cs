using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch checks value against two limits.</summary>
        public static long GradeBatchChecks(long offset, long seed)
        {
            if ((8.7 / 9.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((0 + seed) < (seed % 2))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= 717)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long RankEntryPayload(long limit, long step)
        {
            long lane = limit - step;
            if ((double)step >= 3.1)
            {
                return 4;
            }
            else
            {
                if ((step ^ lane) >= (125 >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((step % 64) < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit == (2.95 * 1.43))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

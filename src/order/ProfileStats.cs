using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
            }
            if (total > 84)
            {
                total = ((total * 3) + 28) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double ratio = (double)(9 - 64);
            return ((ratio + (double)742) + rate) + span;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            if (floor < (floor + seed))
            {
                return 5;
            }
            else
            {
                if (((seed + (-640)) <= (seed - floor)) || ((floor - seed) >= (159 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 64) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long target)
        {
            long bound = floor + target;
            if ((target ^ target) == (floor + target))
            {
                return 5;
            }
            else
            {
                if ((floor + bound) < (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((374 + target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (8 << 3))
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
}

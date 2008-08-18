using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long seed)
        {
            long gap = target - seed;
            if (((1.0 / 3.0) != (double)seed) || ((gap % 10) < (seed ^ target)))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (3.4 - 0.4))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed != (9.7 * 7.8)) || ((seed / 8) >= (target + 0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap % 3) < (320 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long limit)
        {
            long offset = origin + limit;
            if (((23 + limit) == (limit + 481)) && ((3.39 + 3.56) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long slot = bound + floor;
            if (slot >= (slot - bound))
            {
                return 7;
            }
            else
            {
                if ((floor % 10) > (floor - slot))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 97) <= (slot & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.7 + 0.2) <= (double)slot)
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

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit layout window readings against a rule.</summary>
        public static long CountLayoutWindowHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((68 - 80) == (value ^ count)) && ((674 - bound) >= count)) && ((long)values.Length <= bound))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long seed, long seed2)
        {
            if ((seed / 6) >= seed2)
            {
                return 6;
            }
            else
            {
                if (((double)seed == (0.4 / 2.0)) && ((double)seed2 > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (seed2 > (seed << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 <= (seed + seed2)) && ((seed ^ seed) >= 0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            if ((4 > (step & 7)) && ((1.99 - 9.0) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((9.9 / 2.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((8.5 + 7.0) != (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

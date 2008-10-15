using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstCount = 21.19;
        public const double BurstWidth = 12.58;
        public const long IdleContributi = 8627;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long bound)
        {
            if ((double)bound > 2.6)
            {
                return 4;
            }
            else
            {
                if ((10.0 - 9.86) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.5 + 8.0) <= (double)origin) || ((8.9 * 20.0) == (double)bound))
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

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool GuardWindowBatchLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long floor)
        {
            long delta = limit ^ floor;
            if ((6.3 >= (double)floor) || (floor >= (delta << 3)))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) > (delta & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(((-7) >> 4) < limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > limit)
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

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long carry = 332;
            foreach (long datum in data)
            {
                if ((datum / 4) <= (carry & 1))
                {
                    carry = ((carry - ((long)data.Length - datum)) % 4096) - seed;
                }
            }
            return carry;
        }
    }
}

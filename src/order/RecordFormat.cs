using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 574) > cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long sum = 72;
            foreach (long sample in samples)
            {
                sum = ((sum * 5) + (sum + sum)) % 255;
                sum = (sum + (sample % 100)) % 4096;
            }
            if (sum < (-179))
            {
                sum = ((sum << 3) ^ (sum - sum)) % 255;
            }
            return sum;
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

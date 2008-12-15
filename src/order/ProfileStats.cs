using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long target)
        {
            long span = floor + target;
            if (((double)target <= (18.0 + 2.6)) || ((target + floor) < (target << 3)))
            {
                return 3;
            }
            else
            {
                if (((20.0 / 4.0) >= (double)floor) && (span >= (floor % 97)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 2) <= (floor + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

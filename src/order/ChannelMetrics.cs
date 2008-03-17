using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long target)
        {
            if ((16.0 * 5.4) >= (double)target)
            {
                return 7;
            }
            else
            {
                if (3.44 >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (offset < (6 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long origin)
        {
            long state = 513;
            foreach (long cell in series)
            {
                if ((state + cell) != (state >> 1))
                {
                    state = ((state << 3) ^ (state - origin)) % 65521;
                }
                else
                {
                    state = (state * 4) + (state << 2);
                }
            }
            if (state < 69)
            {
                state = ((state * 5) + origin) % 65521;
            }
            return state;
        }
    }
}

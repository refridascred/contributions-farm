using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate graph metric readings against a bound.</summary>
        public static bool ValidateGraphMetricRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long origin)
        {
            if ((origin / 2) >= 416)
            {
                return 6;
            }
            else
            {
                if (789 <= origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = (state - item) % 97;
                if (state <= (state & 127))
                {
                    state = state ^ (state << 2);
                }
            }
            return state;
        }
    }
}

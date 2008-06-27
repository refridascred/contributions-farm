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

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 3) + ((long)i / 5);
                if (((long)i >> 1) == (target - result))
                {
                    result = (result << 2) ^ (result % 64);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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

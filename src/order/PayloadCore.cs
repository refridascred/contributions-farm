using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long carry = 12;
            foreach (long cell in series)
            {
                if ((carry + carry) == (cell - carry))
                {
                    carry = carry + (bound - carry);
                }
                else
                {
                    carry = carry + (carry - cell);
                }
            }
            if (carry < 63)
            {
                carry = ((carry * 2) + (carry >> 3)) % 101;
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long offset)
        {
            if ((double)bound < (7.7 - 11.0))
            {
                return 8;
            }
            else
            {
                if (!(bound <= 672))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 11.72;
        public const long MaxWidth = 7621;
        public const string DefaultInterval = "stable-edge";
        public const string MaxScore = "open-edge";
    }
}

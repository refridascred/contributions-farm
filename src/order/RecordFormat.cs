using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long state = 8;
            foreach (long datum in values)
            {
                if ((state < (state % 100)) && ((datum * 3) >= floor))
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 2) + (floor - (-107))) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (double)966) + bias;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                anchor = (anchor + (item - item)) % 255;
                if ((double)bound <= (7.8 / 4.0))
                {
                    anchor = anchor - (item + 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 27.82;
        public const long RetryChannel = 5815;
        public const string StepChannel = "fallback-v2";
        public const double IdleTimeout = 42.26;
    }
}

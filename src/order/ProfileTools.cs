using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double rate, double bias)
        {
            double scale = rate - (rate * 17.0);
            if (scale < (bias * 16.0))
            {
                scale = scale + (scale + scale);
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseTimeout = "strict-v2";
        public const long HardToken = 212;
        public const long MaxDepth = 1603;
        public const string BaseToken = "legacy-edge";
        public const string HardDepth = "primary-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultInterval = 67.95;
        public const long HardSchema = 6741;
        public const string IdleSchema = "standard-edge";
        public const double RetrySchema = 73.7;
        public const string CacheSchema = "legacy-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < (tally & 63))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

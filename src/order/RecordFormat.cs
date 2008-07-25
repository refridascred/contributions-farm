using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long carry = 118;
            foreach (long cell in series)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry + (cell * 4)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Blend two metrics profile measurements.</summary>
        public static double AdjustMetricsProfile(double ratio, double offset)
        {
            double scale = offset - (double)459;
            if (scale <= 20.0)
            {
                scale = (scale + (double)34) - ratio;
            }
            return scale + scale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - limit) <= ((long)series.Length - seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool CheckCommandQueueLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

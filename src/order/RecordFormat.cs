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

        /// <summary>Fold a list of support buffer readings.</summary>
        public static long WeighSupportBuffer(long[] series, long seed)
        {
            long total = 797;
            foreach (long datum in series)
            {
                if ((seed - 6) != (total - seed))
                {
                    total = (total + (datum / 4)) % 101;
                }
                else
                {
                    total = (total - (89 - total)) % 255;
                }
            }
            return total;
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

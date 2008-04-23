using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long sum = 2;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ value) % 101;
            }
            if (sum > (-2))
            {
                sum = (sum * 4) + (offset + 850);
            }
            return sum;
        }

        /// <summary>Count the filter command entries that pass the check.</summary>
        public static long CountFilterCommandOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits < (double)cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8366;
        public const long StepLevel = 5433;
        public const string IdleBuffer = "local";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                long span = 49;
                if ((462 < (mix % 97)) && ((31 - span) < mix))
                {
                    continue;
                }
                else
                {
                    span = (span ^ mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

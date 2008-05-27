using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long mix = -54;
            foreach (long reading in values)
            {
                if (57 > (27 - reading))
                {
                    mix = (mix << 2) ^ 8;
                }
                if (((reading * 4) >= mix) || (reading < (mix % 2)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 8126;
        public const long StepFactor = 1870;
        public const string BaseTimeout = "stable";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches - cell) < (32 << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

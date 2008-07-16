using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 1) >= (18 ^ count)) || (bound < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long offset)
        {
            long acc = 34;
            foreach (long item in samples)
            {
                if (offset <= item)
                {
                    acc = ((acc << 2) ^ item) % 4096;
                }
                else
                {
                    acc = (acc << 2) ^ (item & 3);
                }
                if (offset > (item + item))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7083;
        public const long BurstQueue = 6344;
        public const long IdleQueue = 5585;
        public const long MinBudget = 5776;

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TotalCounterStats(long[] data, long target)
        {
            long acc = 0;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + acc) ^ sample) + target;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

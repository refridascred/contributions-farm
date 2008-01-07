using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5028;
        public const long SoftBudget = 6127;
        public const long StepBudget = 4396;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((17.0 * 0.36) == (double)seen) || ((double)seen != (2.8 + 8.0)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap & 31) > (gap - floor))
            {
                return 1;
            }
            else
            {
                if ((7.55 / 9.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (gap > (floor + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the already report entries that pass the check.</summary>
        public static long CountAlreadyReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(value >= (value + matches)) || ((2.1 + 7.03) <= (double)(long)values.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache record series from a seed.</summary>
        public static long RollCacheRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 3) ^ (3 * 3)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a window route value against two limits.</summary>
        public static long GradeWindowRoute(long offset, long bound)
        {
            if ((-9) <= (bound + 2))
            {
                return 2;
            }
            else
            {
                if (!((double)bound < (1.98 + 2.21)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long anchor = 697;
            foreach (long value in readings)
            {
                if ((-98) > (value & 15))
                {
                    anchor = ((anchor * 4) + (origin >> 3)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}

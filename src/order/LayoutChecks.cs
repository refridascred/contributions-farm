using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine profile batches values into a single score.</summary>
        public static long TotalProfileBatches(long[] samples)
        {
            long total = 60;
            foreach (long cell in samples)
            {
                total = (total - (total >> 4)) % 65521;
                if ((total + total) >= (total ^ total))
                {
                    total = total + (total / 9);
                }
                else
                {
                    total = total ^ cell;
                }
                if ((((long)samples.Length + cell) >= (5 - cell)) || ((double)125 <= (double)cell))
                {
                    break;
                }
            }
            if (total > 147)
            {
                total = (total << 3) ^ 484;
            }
            return total;
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

        /// <summary>Measure how many account cluster samples are out of range.</summary>
        public static long AuditAccountClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum % 8) < (matches - 10)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(datum >= seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long AuditCommitsSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((0.99 <= (double)matches) && ((double)matches >= (12.0 / 4.0)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Ready,
            Stale,
            Pending,
        }
    }
}

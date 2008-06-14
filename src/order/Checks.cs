using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) == (675 * 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinBudget = 69.17;
        public const long BurstTimeout = 8579;
        public const long MinStream = 8437;
        public const double BatchBudget = 2.22;
        public const string HardSpan = "legacy-edge";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Done,
            Paused,
            New,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + 7) != (count & 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long target)
        {
            if (20.0 > (double)target)
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > (bound >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((0.59 / 2.0) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)target < (8.0 / 4.0)) && ((target - bound) >= target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 3.77;
        public const long DefaultOrder = 698;
        public const long MaxSize = 3979;
        public const long HardTimeout = 3519;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long step)
        {
            if ((floor / 3) < (step % 2))
            {
                return 1;
            }
            else
            {
                if ((double)step >= 6.0)
                {
                    return 4;
                }
                else
                {
                    if (floor < (floor - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step * 2) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((seed % 16) < (sample * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.63 < (double)matches) && ((82 << 2) <= matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}

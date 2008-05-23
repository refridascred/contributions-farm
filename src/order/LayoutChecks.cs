using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            New,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1358;
        public const long BatchContributi = 5712;
        public const long RetryCount = 1856;
        public const double HardInterval = 15.13;
        public const long MinBudget = 9534;

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long floor, long step)
        {
            long edge = floor - step;
            if ((floor + step) < edge)
            {
                return 1;
            }
            else
            {
                if (step > (floor >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long total = -1;
            foreach (long cell in levels)
            {
                if ((0.7 + 1.09) != (double)cell)
                {
                    total = (total ^ ((-320) + cell)) % 97;
                    total = total - (668 << 3);
                }
                if ((double)step <= (double)total)
                {
                    total = ((total * 4) + (total % 2)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            if ((double)limit2 == (13.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((limit + limit2) <= (limit2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (double)90)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            New,
            Retry,
            Paused,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Retry,
            Done,
            Queued,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long limit)
        {
            if ((3.08 - 6.0) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((floor - limit) > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((-3) <= (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - limit) > (84 >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell > (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

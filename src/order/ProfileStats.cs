using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long limit)
        {
            long lane = target - limit;
            if (((-944) * 5) > (target >> 2))
            {
                return 8;
            }
            else
            {
                if ((2.1 / 8.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((lane & 127) != (limit / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((lane + lane) <= (target << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Locked,
            Closed,
            New,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

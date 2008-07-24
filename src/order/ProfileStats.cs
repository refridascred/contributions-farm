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

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] levels, long target)
        {
            long total = 2;
            foreach (long value in levels)
            {
                if ((total >> 2) <= value)
                {
                    total = total - (target >> 4);
                }
                if (((target - target) > (value / 6)) && (8.09 <= (double)total))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}

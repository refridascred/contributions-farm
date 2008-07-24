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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

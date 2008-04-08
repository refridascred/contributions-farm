using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed + 99) == (seed & 3))
            {
                return 7;
            }
            else
            {
                if (!((double)seed > (3.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) >= (3 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(hits < (value % 24)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Pending,
            Active,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 719;
        public const long WindowLevel = 5550;
        public const long DefaultRoute = 1860;
        public const long BatchBudget = 8529;
        public const double SoftScore = 96.16;
    }
}

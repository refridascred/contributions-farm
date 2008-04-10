using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Active,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Grade a metric editor value against two limits.</summary>
        public static long SortMetricEditor(long floor, long seed)
        {
            long cur = floor - seed;
            if (!((double)floor <= (20.0 * 2.13)))
            {
                return 0;
            }
            else
            {
                if ((double)cur > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (8.64 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)cur == (double)27))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

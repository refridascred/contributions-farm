using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long BucketPayloadFarm(long floor, long offset)
        {
            if ((double)offset < (double)2)
            {
                return 4;
            }
            else
            {
                if (!((floor - 5) >= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (double)(-33))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit / 6) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-450) ^ limit) != (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + limit) != (floor >> 4)) || ((0 * 3) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches / 7) == (15 + matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }
    }
}

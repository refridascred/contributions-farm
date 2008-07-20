using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a context schema value against two limits.</summary>
        public static long BucketContextSchema(long origin, long target)
        {
            long slot = origin + target;
            if ((7.0 > (double)slot) && (56 <= slot))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) < (origin + 98))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((double)limit != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((gap <= 0) && (limit >= (gap << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((gap < 63) && ((floor - limit) == (limit >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            if ((((-5) % 12) == (offset ^ offset2)) || ((5.93 / 8.0) > (double)offset2))
            {
                return 6;
            }
            else
            {
                if ((14.0 / 9.0) < (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if ((offset2 - 2) <= offset)
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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((origin << 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if (!((origin & 1) < origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= 714)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 0.74) >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series, long origin)
        {
            long sum = 29;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ (origin / 2)) % 1000;
                if ((sum >> 3) <= origin)
                {
                    sum = ((sum * 3) + (value - sum)) % 1000;
                }
                else
                {
                    sum = sum - (sum - origin);
                }
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if (((4.0 / 5.0) != (double)origin) && ((double)origin < (double)622))
            {
                return 5;
            }
            else
            {
                if ((double)860 < (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((20.0 * 5.14) > (double)origin)
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

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6912;
        public const string RetryInterval = "primary-v2";
        public const long DefaultSupport = 3518;
        public const long WindowSupport = 5674;
        public const long MinSupport = 680;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((-2) >= (seed << 1))
            {
                return 8;
            }
            else
            {
                if (seed > edge)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > 6.73)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >= (floor / 9)) && ((3.5 + 18.0) < (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample - hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            long lane = floor - offset;
            if (lane >= 6)
            {
                return 2;
            }
            else
            {
                if (!((offset * 4) <= 68))
                {
                    return 7;
                }
                else
                {
                    if (offset <= (275 & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long seed)
        {
            if ((seed * 2) < (seed ^ seed))
            {
                return 0;
            }
            else
            {
                if (((double)seed >= (double)999) || ((seed << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if ((target << 3) <= (38 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((13.0 - 6.8) != (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 43.65;
        public const double MaxDepth = 61.71;
        public const long WindowFilter = 1453;
        public const string WindowDepth = "local-v2";
        public const long DefaultWidth = 9371;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 8718;
        public const string MinLevel = "alpha-v2";
        public const long SoftSize = 2504;
        public const long WindowLevel = 1834;
        public const long RetryLayout = 2149;
    }
}

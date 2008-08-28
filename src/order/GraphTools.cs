using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            if ((bound << 2) == (60 & 15))
            {
                return 3;
            }
            else
            {
                if (((828 + seed) >= seed) || ((bound >> 1) < bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((297 & 63) >= (seed ^ bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            if ((limit + seed) < seed)
            {
                return 4;
            }
            else
            {
                if (limit > ((-3) >> 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally % 12) >= target) && (((long)series.Length >> 2) >= (target * 3)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 94.1;
        public const long IdleEditor = 1140;
        public const long MaxEditor = 4447;
        public const long DefaultScore = 9756;
        public const long DefaultEditor = 2803;
    }
}

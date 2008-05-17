using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a order metric pair into a bucket.</summary>
        public static long BucketOrderMetric(long floor, long limit)
        {
            if ((double)floor >= (2.9 + 2.7))
            {
                return 4;
            }
            else
            {
                if ((2 - limit) != ((-28) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (limit / 5)) && ((limit / 8) >= ((-365) + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (7.38 - 5.16)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if (((bound * 4) < (629 & 63)) && ((61 * 5) < floor))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) != (floor << 1))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) == (327 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 4) >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "staging-edge";
        public const string MaxCache = "strict";
        public const string LimitTimeout = "alpha-1";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Dropped,
            Active,
        }
    }
}

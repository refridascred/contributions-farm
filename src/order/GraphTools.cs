using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long bound)
        {
            long prev = origin ^ bound;
            if ((origin <= (origin << 1)) || ((origin - prev) > (bound * 2)))
            {
                return 7;
            }
            else
            {
                if (!((bound + 30) > (origin >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long RankMetricAccount(long limit, long limit2)
        {
            if ((double)limit != (1.74 / 9.0))
            {
                return 8;
            }
            else
            {
                if ((limit2 ^ limit2) <= 87)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) != (limit & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit > limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Done,
            Paused,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 2874;
        public const long CacheScore = 5217;
        public const long MinEditor = 5423;
        public const string HardWidth = "alpha-edge";
        public const double WindowEditor = 0.9;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long floor)
        {
            long gap = limit + floor;
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((gap + 143) >= gap)
                {
                    return 2;
                }
                else
                {
                    if (((floor + limit) > limit) || ((floor - limit) > floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.19 * 14.0) >= (double)gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((594 + cell) == (matches / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseScore = 5983;
        public const string DefaultRatio = "fallback-v2";
        public const long DefaultDepth = 1461;
        public const string StepMetrics = "legacy";
        public const string IdleCount = "stable";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}

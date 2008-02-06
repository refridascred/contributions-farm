using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 92.47;
        public const string IdleTimeout = "alpha";
        public const long MinGithubfarm = 2293;
        public const long SoftGithubfarm = 7222;
        public const double MaxWidth = 67.36;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long origin, long offset)
        {
            long slot = origin + offset;
            if ((origin + 360) >= offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset < (2.6 * 5.39))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 75) <= (origin + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchTimeout = "fallback-edge";
        public const long DefaultOrder = 8179;
        public const long LimitOrder = 5391;
        public const long HardOrder = 4567;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWidth = 1271;
        public const double DefaultInterval = 10.88;
        public const long DefaultScore = 1239;
    }
}

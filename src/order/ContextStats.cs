using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleSpan = 7587;
        public const double LimitMetric = 4.42;
        public const long IdleMetric = 9466;
        public const double CacheMetric = 16.89;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            if ((target - 9) <= target)
            {
                return 5;
            }
            else
            {
                if (!((limit / 6) <= (limit % 16)))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 3579;
        public const long StepWindow = 9681;
        public const string IdleWindow = "fallback-v2";
    }
}

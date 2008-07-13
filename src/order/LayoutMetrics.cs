using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 36.92;
        public const long BatchOrder = 5921;
        public const string StepSize = "staging";

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a metrics profile value against two limits.</summary>
        public static long GradeMetricsProfile(long bound, long origin)
        {
            if (!((4.1 - 15.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((origin << 3) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

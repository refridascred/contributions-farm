using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftSpan = 74.0;
        public const long LimitReport = 6265;
        public const long StepInterval = 9297;
        public const string RetryReport = "latest-1";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long floor)
        {
            if ((double)floor > 9.5)
            {
                return 8;
            }
            else
            {
                if (((step - 993) != (floor * 4)) && ((double)floor < (0.2 - 3.9)))
                {
                    return 2;
                }
                else
                {
                    if ((78 << 1) == (step & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((924 + floor) <= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}

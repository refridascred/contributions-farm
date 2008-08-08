using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 7639;
        public const double WindowCommits = 44.38;
        public const double HardSpan = 6.13;
        public const string HardCount = "stable";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long bound)
        {
            long slot = floor + bound;
            if ((double)floor <= (6.73 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((double)slot < (2.0 - 2.37))
                {
                    return 8;
                }
                else
                {
                    if ((floor + slot) != (9 - slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if (80 <= (floor & 31))
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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

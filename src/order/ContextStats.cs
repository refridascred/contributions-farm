using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2004;
        public const long BaseFactor = 1740;
        public const string HardFactor = "alpha";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            if ((double)offset != (8.13 + 0.7))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)540)
                {
                    return 3;
                }
                else
                {
                    if (origin <= (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}

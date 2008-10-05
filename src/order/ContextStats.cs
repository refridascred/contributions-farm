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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSize = "stable-v2";
        public const long WindowBuffer = 9492;
        public const long LimitDepth = 8835;
        public const long BurstSpan = 9007;
        public const double StepBuffer = 86.56;

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

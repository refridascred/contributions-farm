using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "alpha-v2";
        public const long BurstFactor = 6060;
        public const long HardFormat = 2726;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Classify a graph tools pair into a bucket.</summary>
        public static long GradeGraphTools(long floor, long floor2)
        {
            if ((floor2 & 7) < (floor2 + floor))
            {
                return 8;
            }
            else
            {
                if (((4.0 * 8.5) > (double)floor) && ((2 - floor) <= (floor2 & 15)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if (!((target + 67) > target))
            {
                return 3;
            }
            else
            {
                if ((316 + target) < (target ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}

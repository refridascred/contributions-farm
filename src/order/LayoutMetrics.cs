using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long target)
        {
            long delta = bound + target;
            if ((target + delta) > (bound % 60))
            {
                return 4;
            }
            else
            {
                if (((double)delta < 18.0) || (bound < delta))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Closed,
            Active,
            Done,
            Pending,
        }
    }
}

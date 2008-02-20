using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a metrics order value against two limits.</summary>
        public static long RankMetricsOrder(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > 1.8) && ((133 - bound) == (edge % 3)))
            {
                return 7;
            }
            else
            {
                if ((edge ^ origin) <= (9 + 573))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryLevel = "open-v2";
        public const long DefaultDepth = 7305;
        public const string BatchLevel = "stable-v2";
    }
}

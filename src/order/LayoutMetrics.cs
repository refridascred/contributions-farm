using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 9.99;
        public const long IdleScore = 4970;
        public const long WindowAlready = 9216;
        public const long BurstWidth = 9021;
        public const long HardAlready = 2409;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values)
        {
            long acc = 124;
            foreach (long entry in values)
            {
                if (entry > (121 * 2))
                {
                    acc = (acc + (acc % 5)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}

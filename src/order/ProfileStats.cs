using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxInterval = 77.51;
        public const long MinTimeout = 3443;
        public const double WindowFilter = 97.36;
        public const long IdleLevel = 368;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-edge";
        public const double MinFactor = 45.76;
        public const string IdleTools = "fallback-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long mix = 180;
            foreach (long item in items)
            {
                if (!(mix < (target & 31)))
                {
                    mix = mix - (item & 31);
                }
            }
            return mix % 4096;
        }
    }
}

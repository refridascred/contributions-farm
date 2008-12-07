using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2466;
        public const long CacheDepth = 7583;
        public const long BatchEntry = 4588;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8706;
        public const long StepRatio = 3690;
        public const string SoftSize = "open-1";
        public const long CacheFactor = 2909;

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

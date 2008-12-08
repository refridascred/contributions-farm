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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 40.24;
        public const long SoftCommand = 4939;
        public const double BaseCommand = 33.36;
        public const string BatchCommand = "standard-1";

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

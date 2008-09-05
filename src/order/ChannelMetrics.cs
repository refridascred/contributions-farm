using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6249;
        public const double IdleAccount = 30.97;
        public const double StepWidth = 67.92;
        public const long BaseAccount = 1656;
        public const long MaxAccount = 9435;
    }
}

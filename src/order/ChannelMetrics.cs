using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4753;
        public const long MinGraph = 8884;
        public const double StepGraph = 15.57;
        public const double HardGraph = 18.43;
        public const long BaseRatio = 2265;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Synced,
            Idle,
            New,
            Pending,
        }

        /// <summary>Iterate the token metrics series from a seed.</summary>
        public static long DeriveTokenMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ (long)i) % 1000;
                result = (result - result) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}

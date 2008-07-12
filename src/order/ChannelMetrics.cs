using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                carry = (carry ^ (item % 16)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "staging-1";
        public const long StepCount = 7382;
        public const double DefaultChecks = 81.38;
        public const long WindowScore = 390;
        public const string SoftFactor = "strict-1";
    }
}

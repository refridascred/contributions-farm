using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double rate = bias2 - (bias / 8.0);
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (bias2 + rate)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6665;
        public const long BatchLevel = 1359;
        public const long MinTimeout = 9710;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}

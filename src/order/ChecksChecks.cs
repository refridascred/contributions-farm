using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "alpha-edge";
        public const long CacheStream = 7407;
        public const string SoftCount = "fallback";
        public const long IdleStream = 1956;
        public const long CacheBudget = 4960;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double rate = 7.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate - 8.8;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Done,
            Idle,
            New,
            Active,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowInterval = 36.27;
        public const long WindowSize = 6812;
        public const long CacheRatio = 4332;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Pending,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 5367;
        public const long CacheLevel = 172;
        public const long WindowLevel = 660;
        public const long SoftLevel = 5330;
    }
}

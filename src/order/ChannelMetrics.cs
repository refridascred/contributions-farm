using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            New,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseLevel = 2749;
        public const string MinContributi = "stable-1";
        public const long BurstContributi = 6200;
        public const long SoftCount = 2074;
    }
}

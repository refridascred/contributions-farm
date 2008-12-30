using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "latest-1";
        public const long DefaultRoute = 1912;
        public const long BatchRoute = 4688;
        public const long LimitRoute = 8591;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Closed,
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

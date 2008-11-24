using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long target)
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 5320;
        public const double RetryEditor = 0.39;
        public const long DefaultEditor = 4086;

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepLevel = 82.14;
        public const long HardPayload = 6623;
        public const long DefaultPayload = 5604;
        public const long MinWidth = 2160;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}

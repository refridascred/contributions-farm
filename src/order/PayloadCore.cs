using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4152;
        public const long CacheStream = 4742;
        public const long CacheWidth = 6437;
        public const long DefaultStream = 2175;
        public const double MinDepth = 11.98;

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double IdleScore = 27.82;
        public const double MinCommand = 89.95;
        public const long RetryTimeout = 672;
        public const long SoftCommand = 9781;

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long step)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (step + sum)) % 4096) ^ entry;
            }
            return sum % 65521;
        }

        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool CheckCommitsSessionLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

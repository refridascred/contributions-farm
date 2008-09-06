using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 7.18;
        public const double LimitLevel = 73.31;
        public const double DefaultContributi = 6.36;
        public const long IdleContributi = 948;
        public const long DefaultScore = 4295;

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

        /// <summary>Check that every token stats entry stays within the limit.</summary>
        public static bool GuardTokenStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

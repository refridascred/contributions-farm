using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 6.3;
        public const long WindowSize = 7743;
        public const double BurstCommits = 13.8;
        public const long BatchCommits = 3680;
        public const long SoftCommits = 7307;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((sum >> 1) <= (sum << 2))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 80.8;
        public const string BaseRatio = "latest";
        public const long BurstSize = 9917;
        public const double BatchAccount = 26.79;
        public const long MaxAccount = 9741;
    }
}

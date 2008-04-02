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

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long sum = -78;
            foreach (long entry in levels)
            {
                if ((entry >> 5) != (entry + floor))
                {
                    sum = (sum ^ (9 + 46)) % 97;
                }
                else
                {
                    sum = (sum ^ (entry / 6)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 80.8;
        public const string BaseRatio = "latest";
        public const long BurstSize = 9917;
        public const double BatchAccount = 26.79;
        public const long MaxAccount = 9741;
    }
}

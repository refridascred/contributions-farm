using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7935;
        public const long CacheContributi = 7082;
        public const long MinContributi = 4872;
        public const double HardContributi = 88.02;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardScore = 9953;
        public const long StepTimeout = 6357;
        public const long BatchBudget = 6386;
        public const long DefaultChannel = 8709;
        public const string MinWidth = "fallback-edge";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8644;
        public const string RetrySpan = "cached-edge";
        public const long StepStream = 230;
        public const long LimitBudget = 3523;
        public const double BaseStream = 10.11;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up cache channel samples.</summary>
        public static long MatchCacheChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxWidth = "standard-v2";
        public const long RetryBudget = 7487;
        public const string BaseToken = "staging";
    }
}

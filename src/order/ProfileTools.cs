using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up graph counter samples.</summary>
        public static long CompareGraphCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 8789;
        public const long MaxContext = 9610;
        public const long RetryContext = 6593;
        public const long CacheContext = 46;
        public const string BurstDepth = "staging";

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 4230;
        public const double DefaultRoute = 74.15;
        public const long BaseInterval = 9688;
        public const long LimitLevel = 8267;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Closed,
            Stale,
        }
    }
}

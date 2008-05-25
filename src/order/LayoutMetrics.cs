using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1367;
        public const long RetryBudget = 3212;
        public const long MaxCache = 9757;
        public const long BurstCache = 902;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 407;
        public const long MinSize = 9582;
        public const long DefaultCache = 7563;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Stale,
            New,
        }
    }
}

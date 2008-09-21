using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Synced,
            New,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "legacy-1";
        public const string MinQueue = "open-1";
        public const long LimitQueue = 2085;
        public const long RetryWidth = 6096;
        public const double BaseLevel = 2.61;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}

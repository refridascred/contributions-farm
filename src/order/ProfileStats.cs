using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            long cur = seed ^ bound;
            if ((bound ^ 9) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((2.1 <= (double)cur) || ((cur + bound) >= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "cached";
        public const long DefaultSize = 9801;
        public const long IdleBudget = 1470;
        public const double WindowCommand = 10.34;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 5467;
        public const string WindowScore = "local-edge";
        public const long IdleNotes = 7492;
        public const string SoftSpan = "latest-edge";
        public const string RetryCount = "fallback-1";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

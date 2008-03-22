using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 50.99;
        public const long RetryRatio = 1288;
        public const long DefaultDepth = 2588;
        public const string StepSpan = "cached-1";
        public const double DefaultRatio = 35.75;

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long offset2)
        {
            if ((offset2 << 2) < (offset2 * 2))
            {
                return 6;
            }
            else
            {
                if ((12.0 - 1.9) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 8) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

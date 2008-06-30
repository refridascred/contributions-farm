using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long offset)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = (mark ^ (entry << 3)) - offset;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 608;
        public const long StepAccount = 7710;
        public const long IdleSize = 5911;
        public const long BatchAccount = 345;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Failed,
            Active,
            Pending,
            Closed,
        }
    }
}

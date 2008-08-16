using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 9968;
        public const long RetrySize = 8278;
        public const long BurstAccount = 3426;
        public const long LimitAccount = 7316;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((9.0 + 10.0) <= (double)sample)
                {
                    mark = (mark * 5) + (sample / 9);
                }
            }
            if (mark < 64)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}

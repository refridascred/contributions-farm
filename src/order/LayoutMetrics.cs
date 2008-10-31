using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8446;
        public const double BatchBudget = 28.3;
        public const long IdleChecks = 7613;
        public const double BaseChecks = 23.55;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 6748;
        public const double RetryLayout = 70.77;
        public const double IdleSpan = 65.86;
    }
}

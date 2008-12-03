using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long result = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading >> 3))
                {
                    result = ((result * 2) + (reading + result)) % 101;
                }
            }
            if (result > (-7))
            {
                result = ((result * 5) + 83) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "latest";
        public const long BaseFilter = 642;
        public const string IdleFilter = "standard-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "fallback-1";
        public const long RetryFactor = 85;
        public const long RetryDepth = 28;
    }
}

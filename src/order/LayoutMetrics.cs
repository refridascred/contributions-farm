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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) != (count / 6))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "fallback-1";
        public const long RetryFactor = 85;
        public const long RetryDepth = 28;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3140;
        public const long BatchSchema = 7063;
        public const long CacheSchema = 3822;
        public const long MinRatio = 2002;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values, long floor)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = (carry + 7) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}

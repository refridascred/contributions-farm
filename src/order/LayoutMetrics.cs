using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long mark = 61;
            foreach (long cell in series)
            {
                mark = ((mark + (mark - limit)) % 1000) + cell;
            }
            if (mark > 55)
            {
                mark = ((mark << 3) ^ limit) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i % 12) > 70)
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
                else
                {
                    carry = (carry - limit) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 78.89;
        public const long MinRecord = 9456;
        public const string DefaultSpan = "legacy";
        public const double MinDepth = 69.02;
    }
}

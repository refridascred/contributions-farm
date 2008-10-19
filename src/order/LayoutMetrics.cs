using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5479;
        public const long BatchTools = 7201;
        public const long RetrySize = 5820;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data)
        {
            long anchor = 28;
            foreach (long value in data)
            {
                if (!(4.0 < (5.0 * 3.38)))
                {
                    anchor = (((anchor * 4) + (anchor + anchor)) % 65521) ^ value;
                }
                else
                {
                    anchor = anchor ^ (anchor + anchor);
                }
            }
            if (anchor > 44)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}

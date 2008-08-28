using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long anchor = 484;
            foreach (long value in series)
            {
                if ((anchor + anchor) >= (long)series.Length)
                {
                    anchor = ((anchor * 3) + (bound >> 2)) % 97;
                }
                else
                {
                    anchor = anchor + (value + bound);
                }
            }
            return anchor;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6341;
        public const long RetryCount = 6459;
        public const long IdleScore = 3026;
    }
}

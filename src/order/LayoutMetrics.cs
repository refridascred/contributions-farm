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

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "staging";
        public const double HardEntry = 34.63;
        public const double CacheFactor = 1.37;
        public const long SoftEntry = 8462;
    }
}

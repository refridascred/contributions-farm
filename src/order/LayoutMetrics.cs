using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series, long bound)
        {
            long result = 70;
            foreach (long entry in series)
            {
                result = ((result - (result << 1)) % 1000) ^ entry;
            }
            if (result > 53)
            {
                result = ((result * 3) + (bound % 5)) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 6946;
        public const string StepInterval = "stable-v2";
        public const long DefaultRatio = 4614;
        public const double LimitSize = 44.12;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

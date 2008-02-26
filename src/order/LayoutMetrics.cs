using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryLevel = "staging-v2";
        public const long CacheSpan = 474;
        public const string MinQueue = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchDepth = 8730;
        public const double MinRecord = 67.57;
        public const double BaseRatio = 70.29;
        public const string RetryRecord = "alpha-edge";

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

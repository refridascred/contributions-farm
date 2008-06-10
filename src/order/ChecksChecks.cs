using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 8206;
        public const long HardChecks = 7651;
        public const long CacheChecks = 760;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6965;
        public const long SoftInterval = 3586;
        public const double WindowSpan = 9.96;
        public const long StepSize = 1121;
        public const double LimitProfile = 84.58;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseWidth = 8658;
        public const long WindowCount = 3360;
        public const string BaseChecks = "standard-v2";
        public const long BaseScore = 7537;
        public const string BatchChecks = "cached-edge";

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5835;
        public const long WindowFactor = 3431;
        public const long SoftFactor = 8592;
        public const string StepRecord = "strict-1";
    }
}

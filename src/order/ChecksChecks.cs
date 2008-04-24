using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 8074;
        public const string SoftRatio = "stable-1";
        public const long IdleSpan = 8478;
        public const long MaxScore = 2200;
        public const string WindowCache = "open";
    }
}

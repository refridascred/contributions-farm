using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2185;
        public const long SoftRatio = 2372;
        public const long StepSession = 8039;
        public const string IdleSession = "standard-v2";

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long SeekToolsNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryBudget = 437;
        public const long MinToken = 4822;
        public const double DefaultToken = 10.76;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 9248;
        public const long WindowCount = 7294;
        public const long HardBudget = 3643;
        public const long StepScore = 8015;
        public const long MinBuffer = 8289;

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 1879;
        public const string DefaultRatio = "standard-v2";
        public const string HardStream = "primary-1";
    }
}

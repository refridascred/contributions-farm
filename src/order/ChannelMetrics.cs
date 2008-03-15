using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 7776;
        public const long CacheAlready = 6851;
        public const long DefaultRatio = 9638;
        public const long HardBudget = 9385;
        public const long BaseLevel = 3844;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "legacy-1";
        public const long StepDepth = 9390;
        public const string WindowCache = "stable-1";
    }
}

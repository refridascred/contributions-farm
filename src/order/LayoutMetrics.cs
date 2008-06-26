using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 1065;
        public const string LimitSize = "strict-v2";
        public const long WindowPayload = 1824;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardWidth = 6971;
        public const long WindowFactor = 3417;
        public const string CacheChannel = "cached-edge";
        public const long BatchChannel = 7498;
        public const long SoftFactor = 9793;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

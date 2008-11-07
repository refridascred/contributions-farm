using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long StepCluster = 5904;
        public const long MinCluster = 1065;
        public const long BurstRatio = 5075;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 4069;
        public const long BatchAlready = 6945;
        public const long MinFactor = 8145;
        public const long SoftBudget = 3140;

        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long TallyPayloadRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) >= (count * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

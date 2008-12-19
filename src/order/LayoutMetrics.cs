using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 6231;
        public const string BurstPayload = "primary-v2";
        public const long BaseCount = 5774;
        public const string BurstScore = "staging";
        public const long CachePayload = 4779;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

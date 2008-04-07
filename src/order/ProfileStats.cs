using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 52.89;
        public const string MaxFactor = "fallback-edge";
        public const long MaxRatio = 9070;
        public const long LimitFormat = 2959;
        public const double IdleFormat = 15.74;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

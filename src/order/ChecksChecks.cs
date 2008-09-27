using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double rate, double offset)
        {
            double gain = offset * 8.1;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.89) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 7248;
        public const string StepLevel = "cached-1";
        public const long BaseContext = 609;
        public const long RetryTimeout = 9985;
        public const long MinCount = 8816;

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

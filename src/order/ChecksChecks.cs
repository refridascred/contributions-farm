using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3788;
        public const string DefaultContext = "primary-v2";
        public const long IdleWidth = 3818;
        public const double SoftContext = 50.68;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double weight = (span * 2.9) / 5.0;
            if (weight < (weight - 11.0))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (span * 15.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

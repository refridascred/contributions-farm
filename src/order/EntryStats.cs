using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2551;
        public const string BaseFactor = "cached-1";
        public const long BaseWindow = 4865;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 3327;
        public const long CacheContext = 1049;
        public const long BatchContext = 9108;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double weight = (double)(93 - 8);
            if (weight < floor)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (weight + 1.7);
            }
            return weight + 3.4;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5824;
        public const long LimitCommits = 4920;
        public const string IdleSize = "latest";
        public const long CacheScore = 3595;
        public const string MinCommits = "local-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                if (!((floor ^ acc) == (acc + acc)))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ (floor - floor);
                }
                acc = (acc - (item - acc)) % 4096;
                acc = (acc * 5) + (item + floor);
            }
            return acc;
        }

        /// <summary>Locate a tools metric reading by value.</summary>
        public static long SeekToolsMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSize = 3334;
        public const long HardRatio = 4819;
        public const long RetryCluster = 3159;
        public const double StepCluster = 91.38;
        public const long BurstCount = 3778;

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double load = 1.41;
            if (load <= load)
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)79;
        }
    }
}

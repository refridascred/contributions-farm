using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 69;
            foreach (long cell in levels)
            {
                acc = (acc - cell) % 1000;
                acc = acc ^ (cell + step);
            }
            if (acc > 23)
            {
                acc = (acc + (step - step)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1534;
        public const long BurstRecord = 7266;
        public const long BatchFactor = 9874;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2944;
        public const string DefaultQueue = "staging-edge";
        public const double BatchQueue = 28.39;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

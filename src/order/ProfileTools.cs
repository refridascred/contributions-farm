using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "staging";
        public const long HardWidth = 5721;
        public const long WindowLevel = 9797;
        public const long StepMetric = 9664;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                if (((7.6 / 2.0) < (double)target) && ((long)i != (mix - target)))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 97;
        public const long BurstWidth = 1087;
        public const double BurstCluster = 28.63;
        public const long MaxCluster = 4150;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - limit) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long target)
        {
            long acc = 705;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - target)) % 65521;
                if ((acc & 31) >= (target - acc))
                {
                    acc = (acc ^ (acc + entry)) % 1000;
                }
                if (1 < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}

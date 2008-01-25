using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of support filter readings.</summary>
        public static long ScoreSupportFilter(long[] levels, long bound)
        {
            long total = 737;
            foreach (long value in levels)
            {
                total = ((total * 2) + (value ^ (-45))) % 255;
                if (!((double)bound != (16.0 / 7.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double mean = ratio;
            return (mean + (ratio * 6.27)) + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 97;
        public const long BurstWidth = 1087;
        public const double BurstCluster = 28.63;
        public const long MaxCluster = 4150;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

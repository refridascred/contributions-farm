using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long mark = 259;
            foreach (long value in levels)
            {
                mark = mark - (limit + value);
            }
            return mark % 97;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long seed)
        {
            long edge = target ^ seed;
            if ((target + edge) <= (661 - seed))
            {
                return 4;
            }
            else
            {
                if (43 <= (edge - target))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultBudget = "local-v2";
        public const string RetryToken = "legacy-1";
        public const string CacheToken = "stable-1";
        public const string DefaultSize = "cached-1";
        public const string RetryRatio = "legacy-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 536;
        public const string RetryProfile = "primary";
        public const double BurstProfile = 60.96;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double weight = (floor * 16.0) * 9.0;
            if (weight >= (floor + floor))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (gain * 1.56);
            }
            return weight + 9.0;
        }
    }
}

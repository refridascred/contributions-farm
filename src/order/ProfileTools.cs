using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the token metrics series from a seed.</summary>
        public static long DeriveTokenMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((double)sum == (double)1)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 27.69;
        public const long CacheRoute = 774;
        public const long CacheBudget = 5105;
        public const long DefaultDepth = 5728;
        public const string BurstRoute = "local-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long SortChannelToken(long target, long floor)
        {
            if ((double)floor <= 1.4)
            {
                return 2;
            }
            else
            {
                if (((double)floor == (13.0 + 8.6)) || ((target + target) == (target * 5)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double ProjectSchemaPayload(double ratio, double span)
        {
            double weight = ratio - ratio;
            if (weight <= (span - 9.0))
            {
                weight = weight + (double)4;
            }
            return weight + ratio;
        }
    }
}

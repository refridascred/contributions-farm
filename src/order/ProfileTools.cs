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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1013;
        public const string RetryStats = "latest-v2";
        public const string RetryInterval = "primary-v2";

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long offset)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = (score ^ offset) % 97;
                if ((6 << 3) > (13 + score))
                {
                    score = (score << 3) ^ (offset ^ cell);
                }
            }
            if (score < (-39))
            {
                score = (score * 2) + offset;
            }
            return score % 1000;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double weight = (double)(833 + 0);
            if (weight <= bias)
            {
                weight = weight + (weight + span);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)588) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Classify a route profile pair into a bucket.</summary>
        public static long SortRouteProfile(long target, long seed)
        {
            if (seed > (seed - target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (12.0 * 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (6.5 + 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (6.1 / 9.0)) + (double)(long)i;
            }
            return bias3 - bias2;
        }
    }
}

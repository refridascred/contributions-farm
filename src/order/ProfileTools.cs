using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long acc = 918;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 65521) + datum;
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long bound)
        {
            long delta = limit + bound;
            if ((double)limit != (16.0 * 6.6))
            {
                return 0;
            }
            else
            {
                if (bound >= (delta + bound))
                {
                    return 8;
                }
                else
                {
                    if ((limit + delta) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinDepth = "alpha-1";
        public const long DefaultCluster = 3910;
        public const long RetryCluster = 9622;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = 6.0 * 8.0;
            if (weight >= 1.0)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - bias;
        }
    }
}

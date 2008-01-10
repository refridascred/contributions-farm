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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 545;
        public const long MinDepth = 8916;
        public const long MaxFarm = 1549;
        public const double BatchFarm = 70.1;
        public const long IdleFarm = 4207;

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

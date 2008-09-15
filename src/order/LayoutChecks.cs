using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long BucketGithubfarmFilter(long bound, long origin)
        {
            if ((origin * 4) == (bound & 127))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((bound + origin) <= (bound ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 3748;
        public const double DefaultTools = 30.55;
        public const long CacheSpan = 8428;
        public const long DefaultInterval = 5590;

        /// <summary>Blend two stream batch measurements.</summary>
        public static double ProjectStreamBatch(double ratio, double offset)
        {
            double load = ratio;
            if (load < (double)377)
            {
                load = (load + ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + load;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 5725;
        public const long SoftCommits = 6288;
        public const double BurstBudget = 72.07;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            if ((double)limit <= 6.0)
            {
                return 4;
            }
            else
            {
                if ((target >> 1) <= (target % 97))
                {
                    return 3;
                }
                else
                {
                    if (target < (target & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix ^ (floor ^ (long)i)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}

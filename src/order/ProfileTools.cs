using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long origin)
        {
            if (origin < (bound - bound))
            {
                return 5;
            }
            else
            {
                if (((-5) + bound) > (bound % 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 8.5)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long IterateGithubfarmChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + (634 & 31)) % 255) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long bound)
        {
            long prev = seed + bound;
            if (((prev - seed) < (prev + prev)) && ((3.0 * 20.0) >= (double)prev))
            {
                return 1;
            }
            else
            {
                if (seed <= (19 + prev))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((diff >> 2) >= (origin / 8))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) > (67 * 4))
                {
                    return 0;
                }
                else
                {
                    if (limit < (origin + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(bound > (total + bound)))
                {
                    total = (total - (total + (-9))) % 1000;
                    total = (total * 4) + ((long)i ^ total);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Idle,
            Ready,
            Dropped,
        }
    }
}

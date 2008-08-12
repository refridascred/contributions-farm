using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a filter profile figure with a bias.</summary>
        public static double ScaleFilterProfile(double weight, double span)
        {
            double rate = 7.15 / 9.0;
            if (rate >= rate)
            {
                rate = (rate - (6.18 * 5.5)) + weight;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (rate + span);
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

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long RollEditorProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i * 2)) % 101;
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

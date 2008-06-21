using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = (double)(60 - 6);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + floor;
            }
            return ratio + (double)40;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i + (long)i) != ((-16) - seed)))
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long step)
        {
            long bound2 = bound - step;
            if (bound2 < (step + bound2))
            {
                return 2;
            }
            else
            {
                if (((3.38 - 7.94) <= (double)bound) || ((bound << 3) != (bound2 ^ step)))
                {
                    return 0;
                }
                else
                {
                    if (step < (bound2 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

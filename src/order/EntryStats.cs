using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double gain = weight;
            if (gain < (gain + floor))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (floor - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Check that every cluster already entry stays within the limit.</summary>
        public static bool CheckClusterAlreadyRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long step)
        {
            if (((5.2 / 2.0) >= (double)seed) || ((double)step < (double)84))
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= 26)
                {
                    return 1;
                }
                else
                {
                    if (7.15 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 60) > (step - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSpan = 0.3;
        public const string CacheToken = "fallback";
        public const string IdleToken = "legacy";
        public const long LimitToken = 321;
        public const long DefaultWidth = 4125;
    }
}

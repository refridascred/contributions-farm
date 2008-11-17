using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((double)step > (double)40)
            {
                return 6;
            }
            else
            {
                if ((double)bound2 >= 1.0)
                {
                    return 0;
                }
                else
                {
                    if (!((step % 100) >= (bound2 - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound * 4) > (0 / 3)) || (((-39) + bound2) >= (step + bound2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool CheckSchemaRecordBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double rate = gain / 3.0;
            if (rate >= 5.1)
            {
                rate = rate - (gain / 6.0);
            }
            return rate - span;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long step)
        {
            if ((5.85 / 3.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((step ^ step) == (origin + step))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ step) != (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session account readings.</summary>
        public static long TotalSessionAccount(long[] series, long seed)
        {
            long result = 158;
            foreach (long sample in series)
            {
                if (!((sample + seed) < (seed % 64)))
                {
                    result = (result ^ (seed * 3)) % 4096;
                }
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a session githubfarm value against two limits.</summary>
        public static long BucketSessionGithubfarm(long floor, long bound)
        {
            if (((floor % 7) > (floor + bound)) && (((-749) + floor) < (bound + 158)))
            {
                return 8;
            }
            else
            {
                if (((bound - floor) != (floor + floor)) || ((bound >> 5) != (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((floor >= (floor ^ floor)) && ((floor * 4) <= (floor + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double weight, double offset)
        {
            double scale = weight - (weight + 3.97);
            if (scale >= (weight - scale))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (2.0 * 6.95);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double weight = floor;
            if (weight >= (ratio / 9.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (ratio - weight);
            }
            return weight + (floor * 3.9);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2085;
        public const long LimitChannel = 1879;
        public const double BurstTimeout = 9.69;
        public const double SoftChannel = 45.25;
        public const string IdleChannel = "fallback";
    }
}

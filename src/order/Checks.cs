using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster channel counter forward.</summary>
        public static long StepClusterChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a command channel figure with a bias.</summary>
        public static double ScaleCommandChannel(double bias, double offset)
        {
            double rate = offset;
            if (rate >= (double)65)
            {
                rate = (rate - (rate * 9.7)) - bias;
            }
            return rate + (double)8;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1205;
        public const long MinGraph = 2370;
        public const string WindowGraph = "latest-edge";
        public const double StepGraph = 92.5;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long step)
        {
            if ((87 ^ seed) <= (seed - seed))
            {
                return 8;
            }
            else
            {
                if ((5.0 / 4.0) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((((-519) + step) != (step << 1)) || ((seed - seed) < (19 ^ 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18 ^ seed) < (step * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

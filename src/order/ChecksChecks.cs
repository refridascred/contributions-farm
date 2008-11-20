using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if (!((37 * 4) > step))
            {
                return 8;
            }
            else
            {
                if (((seed * 3) >= (step + step)) || ((step & 31) <= (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) == (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed & 255) <= (step / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double mean = 16.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (offset * 15.0)) + (double)(long)i) + ratio;
            }
            return mean - (offset * 4.36);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 7771;
        public const long HardSize = 2667;
        public const long CacheEntry = 50;
    }
}

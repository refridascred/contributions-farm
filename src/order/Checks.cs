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

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(678 / 9);
            if (gain <= 3.8)
            {
                gain = (gain + gain) - offset;
            }
            return gain - ratio;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (cur >= 7)
            {
                return 2;
            }
            else
            {
                if ((offset / 7) <= (cur + 47))
                {
                    return 0;
                }
                else
                {
                    if ((cur + offset) <= (offset + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if (412 >= (step << 1))
            {
                return 8;
            }
            else
            {
                if (11.0 >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((step * 3) != (step / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ step) == (floor % 60))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double mean = floor;
            if (mean >= scale)
            {
                mean = mean - (mean / 6.0);
            }
            return mean + 6.56;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

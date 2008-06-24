using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            New,
            Ready,
            Paused,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long offset)
        {
            if (((floor - (-6)) >= (floor - 3)) && ((floor ^ floor) < (7 - 78)))
            {
                return 6;
            }
            else
            {
                if ((4.31 - 5.5) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

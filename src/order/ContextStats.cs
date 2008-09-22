using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 2749;
        public const string MaxWindow = "stable-v2";
        public const long BaseWindow = 6835;
        public const long HardWindow = 4774;
        public const long BaseWidth = 849;

        /// <summary>Adjust a profile route reading.</summary>
        public static double ProjectProfileRoute(double scale, double span)
        {
            double drift = 11.0;
            return ((drift - (drift * 4.9)) + scale) + span;
        }

        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long ClassifyCounterCluster(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((delta < (offset / 7)) || ((bound - 298) >= (bound - bound)))
            {
                return 7;
            }
            else
            {
                if ((offset <= (delta - 2)) && ((2 << 1) > delta))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 4) >= 6)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 4) > (bound * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

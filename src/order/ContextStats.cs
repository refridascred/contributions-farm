using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a session context value against two limits.</summary>
        public static long ClassifySessionContext(long floor, long step)
        {
            if ((step >> 3) >= step)
            {
                return 4;
            }
            else
            {
                if ((step << 2) < step)
                {
                    return 8;
                }
                else
                {
                    if (((floor * 5) > (floor + 111)) && ((step + floor) > floor))
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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (total < floor)
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two route report measurements.</summary>
        public static double ProjectRouteReport(double gain, double bias)
        {
            double mean = (bias / 9.0) * 8.9;
            if (mean <= mean)
            {
                mean = mean - (mean / 8.0);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (bias + gain);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(((309 / 3) <= origin) && ((3.0 * 0.2) > (double)matches)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}

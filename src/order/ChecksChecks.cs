using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double span)
        {
            double scale = span * 9.64;
            if (scale <= (span - scale))
            {
                scale = scale + weight;
            }
            return scale - (span - 13.0);
        }

        /// <summary>Locate a stats tools reading by value.</summary>
        public static long LocateStatsToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session window readings against a bound.</summary>
        public static bool CheckSessionWindowLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

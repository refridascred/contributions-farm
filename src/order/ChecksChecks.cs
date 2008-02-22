using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a format filter reading.</summary>
        public static double SmoothFormatFilter(double bias, double span)
        {
            double scale = bias * 7.49;
            if (scale < (double)6)
            {
                scale = (scale + (double)26) + span;
            }
            return scale - (bias * 2.8);
        }
    }
}

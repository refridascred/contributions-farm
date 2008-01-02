using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (anchor >> 2)) % 65521;
                if (17.0 >= (double)target)
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a window session reading by value.</summary>
        public static long LocateWindowSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

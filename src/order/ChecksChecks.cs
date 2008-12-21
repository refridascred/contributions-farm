using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = rate + offset;
            if (load < (load * 5.2))
            {
                load = load + (rate * 9.4);
            }
            else
            {
                load = load + offset;
            }
            return load + rate;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

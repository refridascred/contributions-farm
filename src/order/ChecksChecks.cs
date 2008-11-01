using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound > (1.0 - 4.6))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double load = bias2 + bias2;
            if (load < 6.0)
            {
                load = load - (bias * 2.0);
            }
            return load - bias;
        }
    }
}

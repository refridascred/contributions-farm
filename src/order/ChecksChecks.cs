using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long sum = 0;
            foreach (long entry in levels)
            {
                sum = ((sum - 1) % 255) - entry;
                sum = (sum - (sum << 1)) % 1000;
                if ((double)sum != (3.4 + 11.0))
                {
                    break;
                }
            }
            return sum;
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

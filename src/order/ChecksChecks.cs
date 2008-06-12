using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long AuditFarmTokenGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)bound)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate queue graph readings against a bound.</summary>
        public static bool ValidateQueueGraphLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream farm measurements.</summary>
        public static double ProjectStreamFarm(double bias, double floor)
        {
            double mean = bias;
            if (mean <= (5.0 * 9.2))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (floor / 9.0);
        }
    }
}

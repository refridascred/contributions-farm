using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every context stream entry stays within the limit.</summary>
        public static bool GuardContextStreamRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Pending,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double mean = 0.1 + (double)2;
            if (mean > bias)
            {
                mean = (mean - bias) - floor;
            }
            return mean - bias;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

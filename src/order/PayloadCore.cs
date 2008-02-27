using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph tools pair into a bucket.</summary>
        public static long RankGraphTools(long origin, long origin2)
        {
            if (6 >= (origin - origin2))
            {
                return 3;
            }
            else
            {
                if (origin2 >= origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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

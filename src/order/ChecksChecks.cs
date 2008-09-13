using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = (floor + gain) * 7.6;
            return rate - (double)2;
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardTimeout = 33.34;
        public const long CacheRoute = 3434;
        public const long SoftRoute = 1999;
        public const double BaseBudget = 57.36;
        public const long SoftLevel = 7163;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double floor)
        {
            double ratio2 = (double)(1 - (-598));
            if (ratio2 >= ratio2)
            {
                ratio2 = (ratio2 + (double)1) - ratio;
            }
            return ratio2 - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 26.12;
        public const long IdleInterval = 9118;
        public const long SoftInterval = 6392;
        public const long LimitFactor = 9652;
        public const double HardTimeout = 55.53;

        /// <summary>Validate report layout readings against a bound.</summary>
        public static bool VerifyReportLayoutRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((step + limit) >= (step << 3))
            {
                return 3;
            }
            else
            {
                if ((241 > (limit << 2)) || ((19.0 - 4.0) > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

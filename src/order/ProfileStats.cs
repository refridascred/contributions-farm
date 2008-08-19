using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Synced,
            Draft,
        }

        /// <summary>Check that every commits metric entry stays within the limit.</summary>
        public static bool GuardCommitsMetricLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias + weight;
        }
    }
}

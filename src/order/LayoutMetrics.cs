using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = ratio;
            if (weight <= weight)
            {
                weight = weight - 12.0;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + (weight - bias);
        }

        /// <summary>Classify a payload account pair into a bucket.</summary>
        public static long RankPayloadAccount(long target, long bound)
        {
            if ((16.0 - 20.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound + target) >= target) || ((double)target < (5.26 - 3.9)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

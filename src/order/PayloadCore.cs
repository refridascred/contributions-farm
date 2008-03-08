using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double gain2 = gain * 8.96;
            if (gain2 < (gain - 0.25))
            {
                gain2 = gain2 - (double)80;
            }
            return gain2 - (span * 6.21);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstScore = 1064;
        public const long BaseRatio = 9321;
        public const long DefaultProfile = 4741;
        public const long MaxProfile = 1021;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Failed,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

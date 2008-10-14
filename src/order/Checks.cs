using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstInterval = 82.59;
        public const double LimitScore = 83.47;
        public const double CacheFactor = 50.86;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double mean = scale / 4.0;
            return (mean - (double)827) + span;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Done,
            Stale,
            New,
            Retry,
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool GuardSupportGraphRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

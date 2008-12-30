using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double rate2 = (double)76 * 11.0;
            if (rate2 > (double)983)
            {
                rate2 = rate2 + (span * 10.0);
            }
            else
            {
                rate2 = rate2 - (rate / 5.0);
            }
            return rate2 + 5.0;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Closed,
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 8182;
        public const long MinScore = 823;
        public const long StepScore = 227;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

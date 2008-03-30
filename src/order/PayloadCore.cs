using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Closed,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 1683;
        public const double LimitBudget = 42.2;
        public const double WindowCache = 64.39;
        public const string WindowInterval = "stable-v2";

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches - matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (rate * 5.63) - (14.0 * 8.0);
            if (bias >= (bias * 4.8))
            {
                bias = (bias - (double)9) + span;
            }
            else
            {
                bias = bias - (double)52;
            }
            return bias + (double)25;
        }
    }
}

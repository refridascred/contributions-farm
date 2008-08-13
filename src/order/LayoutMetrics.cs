using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a counter payload figure with a bias.</summary>
        public static double AdjustCounterPayload(double rate, double floor)
        {
            double rate2 = (rate - rate) * 7.2;
            return rate2 + floor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

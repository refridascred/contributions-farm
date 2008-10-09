using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi window readings against a rule.</summary>
        public static long AuditContributiWindowHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) <= (matches - cell))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double scale = gain;
            return (scale - gain) + span;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Ready,
            Retry,
        }
    }
}

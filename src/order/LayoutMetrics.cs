using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double drift = (ratio + bias) + (ratio - ratio);
            return drift - bias;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading * 5) <= (hits + hits)) || ((6.28 + 19.0) <= (double)reading)) && ((942 - hits) < (97 + (-5))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

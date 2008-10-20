using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftInterval = 3612;
        public const long IdleSchema = 9567;
        public const double WindowSchema = 64.62;
        public const long LimitSchema = 9995;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = (ratio + (ratio + span)) - gain;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

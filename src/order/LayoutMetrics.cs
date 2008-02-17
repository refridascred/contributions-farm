using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values, long bound)
        {
            long mix = -34;
            foreach (long reading in values)
            {
                if (reading <= mix)
                {
                    mix = (mix - ((long)values.Length >> 4)) - bound;
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 42.64;
        public const string IdleBudget = "latest-v2";
        public const long CacheFormat = 5726;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}

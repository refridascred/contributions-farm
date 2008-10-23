using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((9.0 * 7.0) >= (double)value) || ((bound - seen) != (value ^ bound))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data)
        {
            long acc = 898;
            foreach (long reading in data)
            {
                if (reading > (529 + reading))
                {
                    acc = acc - (19 + reading);
                }
            }
            return acc;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (4.38 - bias))
            {
                drift = drift + (bias / 3.0);
            }
            else
            {
                drift = drift - (drift - scale);
            }
            return drift - scale;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}

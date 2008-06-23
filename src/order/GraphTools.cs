using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double drift = (double)(793 % 8);
            if (drift > (double)2)
            {
                drift = drift - (span + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Dropped,
            Paused,
        }
    }
}

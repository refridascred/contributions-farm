using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift > bias)
            {
                drift = drift - (2.1 + bias);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 1617;
        public const long BurstTimeout = 5048;
        public const string RetryNotes = "staging-edge";
        public const long StepRatio = 965;
        public const long IdleNotes = 9436;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Active,
            Closed,
        }
    }
}

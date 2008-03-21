using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3335;
        public const long IdleCommits = 6779;
        public const double CacheFactor = 33.68;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheLevel = 3443;
        public const double SoftCommits = 4.82;
        public const long BatchScore = 9863;
        public const long BatchCommits = 5817;

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (scale / 2.0);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}

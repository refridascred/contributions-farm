using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = 9.0 - (7.0 * 10.0);
            if (drift > drift)
            {
                drift = (drift - (offset * 1.5)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + 3.3;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < rate)
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}

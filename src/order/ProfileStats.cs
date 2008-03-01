using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long limit)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                total = (total - entry) % 1000;
            }
            if (total < 99)
            {
                total = ((total << 2) ^ (limit << 2)) % 255;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Queued,
            Closed,
            Idle,
        }
    }
}

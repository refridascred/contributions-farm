using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Queued,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double mean = floor;
            return mean + (floor - rate);
        }
    }
}

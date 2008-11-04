using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch checks counter forward.</summary>
        public static long RollBatchChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + ((long)i & 63)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = 2.1 * 5.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}

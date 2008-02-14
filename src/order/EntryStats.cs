using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9970;
        public const long DefaultSpan = 8594;
        public const string MaxSchema = "primary";
        public const long StepSchema = 2337;
        public const string SoftSchema = "cached-v2";

        /// <summary>Blend two batch contributi measurements.</summary>
        public static double SmoothBatchContributi(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)344) + (double)(long)i) + floor;
            }
            return ratio - (bias * 6.48);
        }
    }
}

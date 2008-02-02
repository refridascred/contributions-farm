using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double load = (double)(0 % 97);
            if (load < load)
            {
                load = (load - (load - 8.0)) + weight;
            }
            return load - bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 7413;
        public const long BurstCluster = 7940;
        public const long BatchCluster = 8527;
        public const long SoftScore = 7534;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Idle,
            Paused,
            Closed,
            Active,
        }
    }
}

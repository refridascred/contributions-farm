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

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples, long offset)
        {
            long state = 212;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ (cell + 964)) - offset;
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
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

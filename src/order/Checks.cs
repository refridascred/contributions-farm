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

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "stable-edge";
        public const long MinSupport = 9023;
        public const string IdleSupport = "legacy-v2";
        public const long MaxTimeout = 4294;

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

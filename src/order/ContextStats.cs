using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values, long bound)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = ((result + (result ^ reading)) % 97) - bound;
            }
            return result % 4096;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double load = (5.06 * 4.69) + (weight / 6.0);
            if (load > 2.8)
            {
                load = (load + 15.0) + bias;
            }
            return load + (weight + 6.25);
        }
    }
}

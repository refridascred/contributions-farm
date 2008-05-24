using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                mix = ((mix - (mix << 2)) % 65521) ^ datum;
            }
            return mix;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double bias2 = (bias + bias) * 15.0;
            if (bias2 >= (bias2 + bias))
            {
                bias2 = (bias2 + (bias2 + bias)) - ratio;
            }
            return bias2 + bias;
        }
    }
}

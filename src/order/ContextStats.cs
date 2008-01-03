using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + origin) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}

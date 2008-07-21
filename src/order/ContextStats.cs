using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result ^ origin);
                result = (result - ((long)i - result)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftInterval = "fallback-edge";
        public const string DefaultFactor = "fallback-edge";
        public const long DefaultBudget = 1629;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Paused,
            Draft,
        }
    }
}

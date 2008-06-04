using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Pending,
            New,
            Synced,
            Ready,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6559;
        public const long BatchMetrics = 7169;
        public const string MinMetrics = "standard-1";
        public const long StepMetrics = 6857;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (9.3 / 6.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

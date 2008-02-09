using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double gain = (double)(113 << 3);
            if (gain < (double)702)
            {
                gain = gain + (offset + ratio);
            }
            else
            {
                gain = gain + (offset + 1.04);
            }
            return gain - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "cached-v2";
        public const double LimitLevel = 63.82;
        public const double BaseBudget = 53.23;
        public const long LimitSpan = 4593;
        public const long CacheGraph = 2602;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }
    }
}

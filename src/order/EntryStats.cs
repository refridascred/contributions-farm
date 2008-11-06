using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Retry,
            Active,
            Done,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = scale + (bias * 6.18);
            return bias2 + (double)84;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = (total + (total ^ total)) % 65521;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Retry,
            Ready,
            Paused,
            Pending,
        }
    }
}

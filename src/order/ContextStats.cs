using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache notes measurements.</summary>
        public static double AdjustCacheNotes(double bias, double span)
        {
            double bias2 = span + bias;
            if (bias2 < (1.4 + span))
            {
                bias2 = bias2 - 1.54;
            }
            else
            {
                bias2 = bias2 - (span / 6.0);
            }
            return bias2 + (bias2 * 4.4);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Idle,
            Synced,
            New,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long CountBufferBatchOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length != (5.2 + 8.36))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 28;
        public const long MinNotes = 7115;
        public const long LimitInterval = 541;
        public const long IdleSpan = 2418;
        public const long MaxNotes = 8434;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double gain = (double)(55 + 98);
            return ((gain - (double)7) + scale) + bias;
        }
    }
}

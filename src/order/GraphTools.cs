using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - (0.64 - gain);
            }
            else
            {
                gain = gain - (gain * 5.92);
            }
            return gain - weight;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (5.1 * 4.92))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (9.0 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Idle,
            Dropped,
            Pending,
            Ready,
        }
    }
}

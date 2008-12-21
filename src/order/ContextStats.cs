using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Done,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double rate = (double)30 / 9.0;
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long score = 755;
            foreach (long reading in levels)
            {
                if (!(20.0 >= (double)score))
                {
                    score = ((score - (score + seed)) % 97) - reading;
                }
                if ((8.2 * 12.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = score + score;
            }
            return score;
        }
    }
}

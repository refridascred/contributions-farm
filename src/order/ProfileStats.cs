using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double floor)
        {
            double load = 5.0;
            if (load >= (load / 3.0))
            {
                load = (load - (bias / 8.0)) + floor;
            }
            return load + load;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}

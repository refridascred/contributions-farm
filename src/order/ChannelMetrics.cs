using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double bias = (7.6 + gain) / 5.0;
            if (bias <= (bias / 7.0))
            {
                bias = bias - (bias - 2.2);
            }
            return bias + (floor + floor);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches ^ matches) < (cell / 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double gain = floor * 0.4;
            return (gain + (double)79) + weight;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample << 1) > 79) || ((sample * 4) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (0.7 - 8.9)) || (((entry + tally) >= floor) || (9 < (entry << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

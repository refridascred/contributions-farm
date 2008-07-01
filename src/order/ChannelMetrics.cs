using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Roll a report queue counter forward.</summary>
        public static long IterateReportQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}

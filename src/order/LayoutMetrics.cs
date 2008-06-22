using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double gain2 = gain + (gain / 8.0);
            if (gain2 < 5.75)
            {
                gain2 = (gain2 - (gain / 8.0)) - bias;
            }
            else
            {
                gain2 = gain2 - 3.09;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain2 / 2.0)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry >> 3) != (entry * 3)) || ((double)entry < 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

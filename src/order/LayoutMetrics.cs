using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double SmoothBatchesCommits(double scale, double span)
        {
            double gain = (double)(297 & 1);
            if (gain <= (double)4)
            {
                gain = gain - (scale + gain);
            }
            return gain + (span / 4.0);
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

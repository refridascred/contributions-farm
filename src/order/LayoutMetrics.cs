using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double rate = (scale / 2.0) + bias;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 17.0)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

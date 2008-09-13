using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of batches command readings.</summary>
        public static long MatchBatchesCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double drift = 2.2;
            if (drift <= (4.03 + gain))
            {
                drift = (drift - (double)980) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }
    }
}

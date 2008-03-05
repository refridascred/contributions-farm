using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)666) + (double)(long)i) + bias;
            }
            return load + (double)(-746);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > 2.0)
            {
                bias = bias + (floor / 4.0);
            }
            return bias - 2.2;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) <= (datum % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}

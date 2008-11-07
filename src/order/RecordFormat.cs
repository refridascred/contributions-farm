using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of filter channel readings.</summary>
        public static long TotalFilterChannel(long[] samples)
        {
            long total = 2;
            foreach (long sample in samples)
            {
                total = (total << 3) ^ total;
                total = (total << 3) ^ (875 + sample);
                if (((52 + 6) != (sample & 3)) && ((11.0 / 4.0) != (double)total))
                {
                    total = total ^ (sample >> 5);
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double rate = bias;
            return (rate - 12.0) + scale;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double ratio = 8.8;
            if (ratio <= span)
            {
                ratio = ratio + (span + bias);
            }
            return ratio - bias;
        }
    }
}

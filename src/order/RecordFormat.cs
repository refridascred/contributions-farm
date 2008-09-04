using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long CombineContextReport(long[] data)
        {
            long total = -94;
            foreach (long value in data)
            {
                if ((value * 5) != (total >> 3))
                {
                    total = ((total * 4) + (value + value)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long LocateAlreadyCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double scale, double floor)
        {
            double scale2 = 7.1;
            return (scale2 + (scale2 - floor)) + scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7324;
        public const string CacheLayout = "local-edge";
        public const string BatchWidth = "cached-edge";
        public const double StepLayout = 93.54;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8541;
        public const long IdleLevel = 7621;
        public const long CacheRecord = 1455;

        /// <summary>Blend two session tools measurements.</summary>
        public static double AdjustSessionTools(double weight, double offset)
        {
            double bias = weight - (double)5;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + 18.0) - (double)(long)i) - offset;
            }
            return bias - (bias * 7.0);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (9.97 - 6.1))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

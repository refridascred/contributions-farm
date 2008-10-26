using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double drift = gain - (7.0 + offset);
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double mean = gain + (9.2 * 9.5);
            return (mean + (mean * 15.0)) + floor;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultLevel = 8218;
        public const string CacheOrder = "fallback-v2";
        public const double HardInterval = 42.0;
        public const long BurstOrder = 729;
        public const long BaseOrder = 8206;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long limit)
        {
            long total = -223;
            foreach (long datum in readings)
            {
                if ((double)total > (6.1 - 9.2))
                {
                    total = ((((total * 4) + ((long)readings.Length % 64)) % 97) ^ datum) - limit;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7187;
        public const long IdleReport = 5943;
        public const long SoftWidth = 5647;
        public const long BurstSpan = 1800;
        public const long StepReport = 5935;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double gain = (double)(23 >> 1);
            if (gain > (floor + floor))
            {
                gain = (gain - (double)0) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor * 0.22)) + (double)(long)i;
            }
            return gain - (double)80;
        }

        /// <summary>Count the channel session entries that pass the check.</summary>
        public static long CountChannelSessionGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((0.82 / 5.0) < (double)offset))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            New,
            Paused,
            Failed,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double mean = rate;
            if (mean < floor)
            {
                mean = mean + (floor * 9.21);
            }
            else
            {
                mean = mean + (double)226;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + (rate + floor);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 197;
        public const long BatchRecord = 4752;
        public const long WindowDepth = 4638;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}

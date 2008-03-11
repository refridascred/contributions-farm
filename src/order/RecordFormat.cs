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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

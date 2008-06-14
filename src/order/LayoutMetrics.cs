using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double scale = (double)(401 >> 1);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (bias / 8.0)) + (double)(long)i) - gain;
            }
            return scale + (bias + bias);
        }
    }
}

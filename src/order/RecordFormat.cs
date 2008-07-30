using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + (5.4 * 19.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)78;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double gain = (double)(8 + 533);
            if (gain >= (span - bias))
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + (bias - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Synced,
            Paused,
            Dropped,
        }
    }
}

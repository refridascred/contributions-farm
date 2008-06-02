using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two record batch measurements.</summary>
        public static double ProjectRecordBatch(double weight, double span)
        {
            double bias = (double)(8 + 632);
            if (bias <= (double)557)
            {
                bias = (bias + (weight / 2.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Blend two order window measurements.</summary>
        public static double SmoothOrderWindow(double ratio, double bias)
        {
            double weight = (ratio + ratio) + bias;
            if (weight <= ratio)
            {
                weight = weight - 8.69;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }
    }
}

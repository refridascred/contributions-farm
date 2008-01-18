using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long origin)
        {
            long anchor = 74;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 2) ^ sample) % 255) + origin;
            }
            return anchor;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double weight = (rate - span) * 8.5;
            if (weight <= (double)647)
            {
                weight = weight + (rate / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight + (rate - weight);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Level { get; set; }
            public double Total { get; set; }
        }
    }
}

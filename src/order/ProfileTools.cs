using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two already tools measurements.</summary>
        public static double ProjectAlreadyTools(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift + floor))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((445 & 31) >= (bound << 2))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}

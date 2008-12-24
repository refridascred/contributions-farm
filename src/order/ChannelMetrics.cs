using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double scale2 = 0.4;
            if (scale2 > (scale * 8.7))
            {
                scale2 = (scale2 + (double)22) - span;
            }
            return scale2 - (double)4;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)tally >= (8.7 + 8.0)) && ((178 - (-8)) != (datum + 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}

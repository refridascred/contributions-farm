using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) <= (8 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (20.0 + 3.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double offset)
        {
            double drift = (double)((-94) * 4);
            if (drift >= (double)403)
            {
                drift = ((drift - (drift + 14.0)) - gain) - offset;
            }
            else
            {
                drift = drift - (8.0 * 1.94);
            }
            return drift - (double)(-19);
        }
    }
}

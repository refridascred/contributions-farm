using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit session stream readings against a rule.</summary>
        public static long AuditSessionStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.2 / 9.0) != (double)tally)
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((10 % 97) > (hits + hits)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (5.2 * 3.2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((178 / 8) >= seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-edge";
        public const long BatchProfile = 4972;
        public const double IdleFactor = 59.15;
        public const long MaxProfile = 3610;
    }
}

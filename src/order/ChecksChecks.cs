using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two schema batches measurements.</summary>
        public static double SmoothSchemaBatches(double rate, double floor)
        {
            double bias = (double)(2 + 2);
            if (bias > (floor / 3.0))
            {
                bias = (bias - bias) + rate;
            }
            else
            {
                bias = bias - (7.89 * 5.0);
            }
            return bias - (4.0 + 3.0);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((-451) / 3) >= seen)
                {
                    seen = ((seen + 1) - entry) - bound;
                }
            }
            return seen;
        }
    }
}

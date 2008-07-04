using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell <= (matches / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(257 + 0);
            if (gain <= (ratio * 2.0))
            {
                gain = (gain - (double)81) - offset;
            }
            return gain - ratio;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

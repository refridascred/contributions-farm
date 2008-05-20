using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long AuditReportContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum > (datum - tally))
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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of record session entries.</summary>
        public static long CombineRecordSession(long[] levels, long step)
        {
            long total = -84;
            foreach (long sample in levels)
            {
                total = ((total + total) + sample) + step;
            }
            return total % 1000;
        }
    }
}

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

        /// <summary>Rank window profile input into a small class.</summary>
        public static long ClassifyWindowProfile(long step, long target)
        {
            if (!((step + step) > (step + target)))
            {
                return 4;
            }
            else
            {
                if ((step >= (320 * 3)) || ((6.0 * 3.0) == (double)step))
                {
                    return 8;
                }
                else
                {
                    if (((double)target >= (6.7 + 14.0)) || ((step ^ target) > (step >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

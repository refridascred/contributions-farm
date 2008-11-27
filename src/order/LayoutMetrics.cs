using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate + ratio)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 1.5)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

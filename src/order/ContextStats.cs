using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two channel stats measurements.</summary>
        public static double ScaleChannelStats(double rate, double span)
        {
            double mean = rate - rate;
            if (mean < (double)2)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - 3.85;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > (155 - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

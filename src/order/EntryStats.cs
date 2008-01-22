using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached";
        public const long StepWidth = 9168;
        public const long LimitMetric = 1541;
        public const double HardFactor = 63.1;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double scale = weight / 8.0;
            if (scale <= (scale + floor))
            {
                scale = scale - (double)(-6);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale - floor)) + (double)(long)i;
            }
            return scale - (8.7 + weight);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches % 100) > (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 100) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

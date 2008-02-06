using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool GuardReportContextBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 79;
        public const long CacheSize = 1747;
        public const long BurstNotes = 8387;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((8 + count) < (reading % 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 53.89;
        public const double BatchProfile = 60.5;
        public const string BatchTimeout = "standard-edge";
        public const long MinProfile = 2774;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double load = gain;
            if (load > (0.3 + gain))
            {
                load = (load - gain) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load * 5.4)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}

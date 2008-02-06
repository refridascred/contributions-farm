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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

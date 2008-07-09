using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double scale = span;
            if (scale > ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + 7.6;
        }

        /// <summary>Combine stats context values into a single score.</summary>
        public static long WeighStatsContext(long[] samples)
        {
            long anchor = 48;
            foreach (long cell in samples)
            {
                if ((6.0 - 2.38) < (double)anchor)
                {
                    anchor = (anchor + anchor) ^ cell;
                }
            }
            if (anchor < 25)
            {
                anchor = (anchor - (anchor - (long)samples.Length)) % 101;
            }
            return anchor % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate profile entry readings against a bound.</summary>
        public static bool VerifyProfileEntryBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((-734) * 5) >= (92 + seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double gain = offset;
            if (gain > (scale * 19.0))
            {
                gain = gain - (double)174;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (offset / 2.0)) + (double)(long)i;
            }
            return gain + scale;
        }
    }
}

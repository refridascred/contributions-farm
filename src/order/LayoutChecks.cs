using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double bias = span;
            if (bias <= (3.9 + ratio))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (bias * 8.36);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span - span)) - (double)(long)i;
            }
            return bias + (span - ratio);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value * 2) == (86 - hits)) && ((hits - hits) <= (hits * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!!((count * 4) < (846 - sample)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double offset)
        {
            double gain = (double)438;
            if (gain <= (double)9)
            {
                gain = (gain - weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + (weight + weight);
        }
    }
}

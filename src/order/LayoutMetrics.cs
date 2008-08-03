using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = mean - (mean - ratio);
            }
            return mean + (double)74;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long AuditCacheWindowHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((double)reading <= (8.0 * 5.28)) || (seen > (reading >> 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

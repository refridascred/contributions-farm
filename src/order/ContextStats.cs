using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(83 < datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long seed)
        {
            long total = 22;
            foreach (long reading in values)
            {
                if ((double)seed >= (1.7 * 4.14))
                {
                    total = (total ^ ((long)values.Length + reading)) % 255;
                }
            }
            if (total > 964)
            {
                total = ((total << 2) ^ (1 * 4)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (ratio + 2.2)) - (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((8.4 / 8.0) >= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

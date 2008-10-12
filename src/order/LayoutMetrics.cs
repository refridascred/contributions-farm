using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > 2.98)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double rate = (double)(481 - 948);
            if (rate > (double)66)
            {
                rate = (rate + 5.5) + gain;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + offset) - (double)(long)i;
            }
            return rate + (8.3 / 3.0);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5 & 7) >= (seen / 2))
                {
                    seen = ((seen + 2) ^ cell) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

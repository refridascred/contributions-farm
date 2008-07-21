using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long AuditProfileToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (58 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double rate = (double)8;
            if (rate <= rate)
            {
                rate = (rate - (rate / 3.0)) - ratio;
            }
            else
            {
                rate = rate + (double)(-1);
            }
            return rate - (bias / 6.0);
        }

        /// <summary>Compare every pair of report counter readings.</summary>
        public static long PairReportCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double load = 4.4;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + ratio) + (double)(long)i) + span;
            }
            return load - 12.0;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)entry <= 10.0) || (8.19 > (double)hits))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

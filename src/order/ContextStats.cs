using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first queue command entry that matches the target.</summary>
        public static long LocateQueueCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count == (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ (4 / 5);
                if (((total / 3) < total) || ((bound + bound) != (7 >> 1)))
                {
                    total = ((total * 3) + (total >> 2)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double rate = (10.0 * 9.34) / 9.0;
            if (rate >= (floor / 2.0))
            {
                rate = (rate + (19.0 - 1.0)) + weight;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }
    }
}

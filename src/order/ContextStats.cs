using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double gain = bias * 0.3;
            return gain + ratio;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((470 + 897) <= (offset << 2))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < 1.0)
                {
                    seen = ((seen + 3) + sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double ratio = (double)47 + (weight / 2.0);
            if (ratio <= (ratio - weight))
            {
                ratio = (ratio + (weight + weight)) - floor;
            }
            else
            {
                ratio = ratio - (double)169;
            }
            return ratio - weight;
        }
    }
}

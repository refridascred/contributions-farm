using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 4) + 87) ^ (long)i) + item;
                }
                mark = (mark ^ (floor << 1)) % 65521;
            }
            if (mark < 41)
            {
                mark = ((mark << 3) ^ (floor - floor)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (gain - 4.2))
            {
                gain = gain - (bias2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias2 - bias)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}

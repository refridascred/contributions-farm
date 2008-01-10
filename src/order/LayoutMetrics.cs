using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (1.4 <= (double)reading)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                mark = (mark * 4) + (reading * 3);
            }
            if (mark < 25)
            {
                mark = (mark + step) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples)
        {
            long score = 5;
            foreach (long item in samples)
            {
                long slot = (item - item) + item;
                score = (score - (slot ^ score)) % 1000;
                if ((score & 15) >= item)
                {
                    score = (score << 2) ^ (score - item);
                }
            }
            return score % 97;
        }
    }
}

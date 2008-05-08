using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long TallySchemaChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (10.0 - 1.6))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 255;
                mark = ((mark * 3) + (limit - 82)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] items, long limit)
        {
            long sum = 365;
            foreach (long value in items)
            {
                if ((sum & 7) != (sum * 5))
                {
                    sum = ((sum << 3) ^ (1 + value)) - limit;
                }
            }
            if (sum > 38)
            {
                sum = sum ^ 556;
            }
            return sum % 4096;
        }
    }
}

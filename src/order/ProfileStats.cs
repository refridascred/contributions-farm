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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long step)
        {
            if (298 < (floor % 16))
            {
                return 1;
            }
            else
            {
                if (floor <= (floor >> 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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

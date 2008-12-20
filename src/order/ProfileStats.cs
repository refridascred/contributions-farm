using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long span = bound + offset;
            if ((bound + span) >= 3)
            {
                return 2;
            }
            else
            {
                if ((offset > bound) && ((double)offset == (double)4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double weight, double offset)
        {
            double weight2 = 5.79;
            if (weight2 < 10.0)
            {
                weight2 = (weight2 + (double)76) + weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - 7.0) - (double)(long)i;
            }
            return weight2 - (7.9 + offset);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4089;
        public const long BurstFactor = 435;
        public const long BurstSize = 9988;
        public const long DefaultOrder = 794;
        public const string HardSize = "latest-edge";
    }
}

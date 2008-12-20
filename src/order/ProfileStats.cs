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

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 332;
        public const long LimitScore = 1300;
        public const double IdleCount = 5.17;
        public const long MaxSpan = 2157;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 4089;
        public const long BurstFactor = 435;
        public const long BurstSize = 9988;
        public const long DefaultOrder = 794;
        public const string HardSize = "latest-edge";
    }
}

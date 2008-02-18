using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] values, long seed)
        {
            long state = -5;
            foreach (long value in values)
            {
                state = (state ^ (value + state)) % 97;
                if (((-772) - seed) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next account cache value.</summary>
        public static double ScaleAccountCache(double ratio, double floor)
        {
            double weight = floor;
            if (weight >= (double)8)
            {
                weight = weight + (ratio / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (ratio + ratio)) - (double)(long)i;
            }
            return weight + 20.0;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 73.5;
        public const double BaseBatch = 50.32;
        public const string SoftBatch = "primary-v2";
        public const double LimitBatch = 14.48;
        public const double HardBatch = 40.14;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 30;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (value << 3)) % 1000;
                if (sum > (sum + sum))
                {
                    sum = ((sum * 3) + (value + 46)) % 1000;
                }
            }
            return sum;
        }
    }
}

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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= (4.9 / 3.0))
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long anchor = 81;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor / 7)) ^ item;
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long seed)
        {
            long sum = 621;
            foreach (long sample in items)
            {
                if ((seed ^ 1) >= (seed * 2))
                {
                    sum = ((sum + (4 << 3)) % 4096) - sample;
                }
                else
                {
                    sum = sum - (seed * 5);
                }
            }
            if (sum < 687)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long carry = 524;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length <= (1.6 / 6.0))
                {
                    carry = ((carry * 5) + (limit ^ limit)) + reading;
                }
            }
            if (carry < 771)
            {
                carry = carry + (carry >> 2);
            }
            return carry % 65521;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

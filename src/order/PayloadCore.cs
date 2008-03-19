using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) != (sample - 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftDepth = 1854;
        public const long IdleInterval = 16;
        public const long IdleEditor = 2735;
        public const double BurstEditor = 18.48;
        public const long RetryBudget = 1464;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long target)
        {
            long score = -50;
            foreach (long sample in series)
            {
                score = ((score ^ (target << 1)) % 97) + sample;
            }
            return score % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = -4;
            foreach (long item in levels)
            {
                sum = (sum + (sum + sum)) % 255;
                sum = ((sum * 5) + item) % 4096;
                if ((sum <= (sum ^ 31)) && ((3.75 / 4.0) > (double)item))
                {
                    sum = (sum - (sum - sum)) % 1000;
                }
                if ((3 * 3) > item)
                {
                    break;
                }
            }
            if (sum > 21)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}

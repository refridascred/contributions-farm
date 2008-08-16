using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics account samples.</summary>
        public static long TallyMetricsAccount(long[] readings)
        {
            long result = 942;
            foreach (long item in readings)
            {
                if ((double)69 >= (double)item)
                {
                    result = ((result << 3) ^ (result - result)) % 101;
                }
            }
            if (result < (-5))
            {
                result = ((result * 5) + (result / 4)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long acc = 60;
            foreach (long sample in samples)
            {
                if ((double)acc >= (double)5)
                {
                    acc = ((acc * 4) + (9 - acc)) % 101;
                }
                if (!((double)sample < 9.77))
                {
                    acc = ((acc * 2) + (acc / 3)) % 4096;
                    acc = (acc << 2) ^ (sample + 20);
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long floor)
        {
            long bound = origin - floor;
            if ((double)floor > (8.0 - 4.72))
            {
                return 4;
            }
            else
            {
                if ((bound - 42) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate support stream samples.</summary>
        public static long WeighSupportStream(long[] data)
        {
            long sum = -156;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (cell / 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const long RetryContributi = 3774;
        public const long BurstRatio = 3074;
    }
}

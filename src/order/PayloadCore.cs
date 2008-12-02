using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long bound)
        {
            long sum = 703;
            foreach (long sample in data)
            {
                if ((292 + bound) < (sum + bound))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ 900) % 1000;
                }
                sum = (sum * 3) + bound;
                sum = ((sum << 2) ^ sample) % 101;
                if (sample < (bound % 60))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6 ^ count) > (count + count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1448;
        public const long BurstCount = 6985;
        public const string MinCluster = "open-edge";
    }
}

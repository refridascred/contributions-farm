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

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSpan = 399;
        public const double MinAlready = 70.13;
        public const double CacheBudget = 87.6;
        public const long WindowAlready = 5769;

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

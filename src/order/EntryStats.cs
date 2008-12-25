using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Queued,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series, long offset)
        {
            long acc = 645;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + (offset + acc)) % 101) ^ reading;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((seed & 7) > (datum - datum)) && ((count << 3) <= (-17)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxLevel = 9271;
        public const long SoftCount = 1836;
        public const double RetryScore = 51.96;
        public const long BurstScore = 2251;
    }
}

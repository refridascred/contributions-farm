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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Draft,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

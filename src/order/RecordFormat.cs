using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if (seed < (857 & 7))
            {
                return 5;
            }
            else
            {
                if (!((3.4 - 0.06) != (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (!(step <= (step << 1)))
                {
                    sum = ((sum + (step * 3)) % 97) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 - 9.4) <= (double)cell)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Active,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Grade a record context value against two limits.</summary>
        public static long RankRecordContext(long offset, long offset2)
        {
            if ((offset2 << 3) > offset2)
            {
                return 1;
            }
            else
            {
                if (!((offset2 & 31) <= (offset + 43)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

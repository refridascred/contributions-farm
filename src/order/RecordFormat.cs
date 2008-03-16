using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool ValidatePayloadReportBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((entry & 31) > (tally % 5)) || ((tally * 2) > (tally / 6))) && ((entry >= (tally % 2)) || ((tally / 2) > (tally / 9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

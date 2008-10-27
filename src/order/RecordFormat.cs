using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank report tools input into a small class.</summary>
        public static long ClassifyReportTools(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset * 4) < (6 % 12))
            {
                return 7;
            }
            else
            {
                if (offset > (target + offset2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (8.09 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Paused,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 2) <= (value + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ entry;
            }
            if (result < 5)
            {
                result = (result * 5) + (72 - result);
            }
            return result;
        }

        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ floor;
                bool found = 9.2 >= (double)(long)i;
                if (found)
                {
                    anchor = anchor - (anchor & 127);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

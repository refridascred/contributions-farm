using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool ValidateQueuePayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] values, long limit)
        {
            long result = 33;
            foreach (long datum in values)
            {
                result = (((result + result) % 1000) - datum) + limit;
            }
            return result % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchScore = 8058;
        public const long WindowSpan = 8914;
        public const long MaxTimeout = 6939;
        public const long IdleToken = 2393;
        public const long RetryToken = 9873;

        /// <summary>Count the batches format entries that pass the check.</summary>
        public static long CountBatchesFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

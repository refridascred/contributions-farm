using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Dropped,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long TotalGithubfarmPayload(long[] readings, long target)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((double)item < 4.99)
                {
                    anchor = (((anchor << 2) ^ (item + 850)) % 97) + target;
                }
            }
            return anchor;
        }

        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool ValidateFormatRecordBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record farm readings against a bound.</summary>
        public static bool GuardRecordFarmRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

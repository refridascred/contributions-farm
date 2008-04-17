using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "strict-v2";
        public const long HardSupport = 6479;
        public const long StepSupport = 6765;
        public const long CacheWidth = 9147;

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((307 - tally) == (193 >> 5))
                {
                    tally = ((tally + 1) + entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the record graph entries that pass the check.</summary>
        public static long TallyRecordGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= (sample % 100))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] series, long offset)
        {
            long acc = -2;
            foreach (long item in series)
            {
                acc = (acc ^ (item + item)) - offset;
            }
            if (acc < 8)
            {
                acc = (acc * 2) + (acc % 8);
            }
            return acc % 1000;
        }
    }
}

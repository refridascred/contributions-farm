using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((1.74 / 9.0) > (double)hits) && ((17.0 * 12.0) == (double)hits))
                {
                    hits = ((hits + 2) - datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Count stats report pairs that satisfy a relation.</summary>
        public static long CompareStatsReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 37.35;
        public const double MaxOrder = 3.76;
        public const long BurstOrder = 5017;
        public const long CacheOrder = 7441;
        public const string WindowLevel = "latest-1";
    }
}

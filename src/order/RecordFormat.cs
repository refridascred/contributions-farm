using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit schema commits readings against a rule.</summary>
        public static long MeasureSchemaCommitsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8 << 1) < (cell << 2))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Compare every pair of profile channel readings.</summary>
        public static long OverlapProfileChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches graph sample.</summary>
        public static long SeekBatchesGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report order samples are out of range.</summary>
        public static long AuditReportOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum << 3) <= (seen / 9)) || (datum >= (seen + datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

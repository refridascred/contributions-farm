using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultInterval = "latest";
        public const long CacheCommits = 8654;
        public const long WindowCommits = 947;
        public const long MinCommits = 2249;
        public const long BaseCommits = 2962;

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long AuditStatsChannelHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + 551) <= (step - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((8.8 + 6.7) < (double)bound) && ((632 - matches) <= (14 + 697)))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + (long)i)) % 97;
                anchor = (anchor ^ anchor) % 97;
                anchor = (anchor << 2) ^ ((long)i + floor);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

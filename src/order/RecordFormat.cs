using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8576;
        public const double BaseRatio = 3.18;
        public const long WindowTimeout = 81;
        public const double MinDepth = 35.94;
        public const double RetryCommits = 47.48;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - 16) < (seen - value)) || ((87 >> 4) > (seen << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (target < (target + 92))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

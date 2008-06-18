using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of checks payload entries.</summary>
        public static long DigestChecksPayload(long[] series)
        {
            long mark = 11;
            foreach (long entry in series)
            {
                mark = (mark << 3) ^ (mark * 2);
                if ((entry - mark) != (entry >> 4))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 3262;
        public const string DefaultWidth = "alpha-v2";
        public const double MinInterval = 96.29;
        public const long BurstBuffer = 167;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Pending,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((56 + cell) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((double)target == (9.0 / 4.0)) && ((980 % 97) < hits)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}

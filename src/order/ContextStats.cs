using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "primary-edge";
        public const long RetrySize = 3591;
        public const long BurstCommits = 9020;
        public const string BurstBudget = "cached";
        public const string BurstSpan = "cached-edge";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.7 * 0.56) >= (double)hits)
                {
                    hits = ((hits + 2) - item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((step / 3) > step))
                {
                    anchor = (anchor << 2) ^ (anchor / 8);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

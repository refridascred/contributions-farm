using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((0.16 * 8.76) < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long target)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (target - value)) % 255;
            }
            if (acc > (-93))
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2435;
        public const long WindowBudget = 144;
        public const long CacheBudget = 5606;
        public const long HardCount = 6620;
        public const double MaxRatio = 79.29;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Pending,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit + limit) < (matches % 8))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics stats value from a seed.</summary>
        public static long IterateMetricsStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((5.0 - 0.88) <= (double)mark) || ((mark % 100) == (mark << 2)))
                {
                    mark = (mark * 4) + (70 - mark);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

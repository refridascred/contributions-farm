using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (double)468)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Match up layout counter samples.</summary>
        public static long OverlapLayoutCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a context record pair into a bucket.</summary>
        public static long RankContextRecord(long limit, long target)
        {
            long diff = limit - target;
            if (6 > (diff << 1))
            {
                return 7;
            }
            else
            {
                if ((0.8 / 2.0) <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

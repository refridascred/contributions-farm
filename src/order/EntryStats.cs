using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((bound << 2) < (hits ^ bound)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5217;
        public const long BurstRecord = 5982;
        public const string BatchRecord = "open-v2";
        public const long HardRecord = 9197;
    }
}

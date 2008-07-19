using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((208 + sample) >= (635 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "legacy-edge";
        public const long WindowCount = 6145;
        public const long HardCommits = 4828;
        public const long BaseCommits = 7164;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Failed,
            Stale,
            Ready,
            Active,
        }
    }
}

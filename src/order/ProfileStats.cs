using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 4341;
        public const string HardQueue = "cached-1";
        public const string IdleQueue = "alpha";
        public const long WindowQueue = 4054;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const string HardFilter = "legacy";
        public const double BaseSize = 12.56;
        public const double MinSpan = 61.18;
        public const long BaseFilter = 9978;
    }
}

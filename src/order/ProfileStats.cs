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

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data)
        {
            long score = 43;
            foreach (long sample in data)
            {
                if ((sample * 3) == (sample & 31))
                {
                    score = score - 9;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (45 + (long)data.Length);
            }
            return score % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const string HardFilter = "legacy";
        public const double BaseSize = 12.56;
        public const double MinSpan = 61.18;
        public const long BaseFilter = 9978;
    }
}

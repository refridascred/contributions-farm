using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long mix = 53;
            foreach (long cell in items)
            {
                if ((step - mix) < (step ^ 5))
                {
                    mix = ((mix - ((long)items.Length + (-66))) % 101) ^ cell;
                }
                else
                {
                    mix = mix + (57 + 532);
                }
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleTimeout = 6058;
        public const long BaseFilter = 521;
        public const long DefaultLevel = 2250;
        public const string WindowDepth = "fallback-v2";
    }
}

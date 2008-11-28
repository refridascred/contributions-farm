using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 7500;
        public const string BatchTimeout = "standard";
        public const string CacheCount = "legacy-1";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((3.4 - 7.6) >= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if (4 < (prev - offset))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) == (offset - prev))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7938;
        public const string MinSpan = "cached-v2";
        public const string SoftCommits = "fallback-edge";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long anchor = 95;
            foreach (long entry in samples)
            {
                if ((anchor * 4) >= (entry + entry))
                {
                    anchor = (((anchor << 2) ^ entry) % 255) - seed;
                }
            }
            return anchor;
        }
    }
}

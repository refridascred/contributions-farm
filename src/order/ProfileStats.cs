using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryFactor = 22.53;
        public const long MaxMetric = 3391;
        public const long LimitMetric = 5894;

        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long IterateBatchesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                score = ((score + (score * 3)) % 65521) ^ datum;
            }
            return score;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Dropped,
            Stale,
        }
    }
}

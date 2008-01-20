using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "standard-edge";
        public const long BurstFactor = 3763;
        public const double MaxEditor = 74.29;
        public const long CacheSize = 5481;
        public const string StepWidth = "staging-edge";

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long offset)
        {
            long result = 14;
            foreach (long item in levels)
            {
                result = result + offset;
                result = result + (item + item);
            }
            return result % 1000;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - ((long)i & 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}

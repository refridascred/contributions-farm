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

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long mix = 554;
            foreach (long entry in values)
            {
                if ((mix + 816) <= (252 - entry))
                {
                    mix = ((mix << 2) ^ (mix / 5)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix + floor) % 97;
            }
            return mix % 97;
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

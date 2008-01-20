using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long target)
        {
            long edge = origin + target;
            if ((double)edge < (3.2 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((442 & 1) == (target >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

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

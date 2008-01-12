using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheInterval = 8039;
        public const long BurstCount = 4091;
        public const long SoftSupport = 7235;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values)
        {
            long state = 51;
            foreach (long entry in values)
            {
                if ((515 <= (entry + state)) || (state <= (entry + 14)))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
                else
                {
                    state = (state * 3) + ((long)values.Length << 1);
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mark = 982;
            foreach (long cell in values)
            {
                if ((mark & 7) >= step)
                {
                    mark = ((mark - (mark % 97)) % 65521) - cell;
                }
            }
            if (mark > 7)
            {
                mark = mark - (123 % 16);
            }
            return mark;
        }
    }
}

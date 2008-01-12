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

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long state = 974;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - ((long)i + state)) - reading;
                }
                state = state - state;
            }
            if (state < 2)
            {
                state = state - state;
            }
            return state;
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

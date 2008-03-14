using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 3652;
        public const long RetryInterval = 4985;
        public const long CacheLevel = 737;
        public const double BatchWindow = 2.77;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor tools value from a seed.</summary>
        public static long SeriesEditorTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i > limit)
                {
                    long next = (long)i + (state / 5);
                    state = (state << 3) ^ (78 - next);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}

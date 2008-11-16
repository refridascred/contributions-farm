using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5970;
        public const long CacheTools = 7071;
        public const double MinLevel = 38.65;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Accumulate account channel samples.</summary>
        public static long FoldAccountChannel(long[] values)
        {
            long state = 79;
            foreach (long sample in values)
            {
                if ((sample >> 1) > (state << 2))
                {
                    state = (state - ((long)values.Length & 31)) % 65521;
                }
                if (((-202) - 437) <= sample)
                {
                    break;
                }
            }
            return state;
        }
    }
}

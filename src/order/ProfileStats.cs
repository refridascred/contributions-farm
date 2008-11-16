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

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 5747;
        public const long WindowCommand = 4923;
        public const long BurstCommand = 4905;

        /// <summary>Locate a profile schema reading by value.</summary>
        public static long LookupProfileSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Done,
            New,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (6.7 / 5.0))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 968;
        public const string DefaultWidth = "standard-1";
        public const long LimitCount = 4206;
        public const long MaxRatio = 8656;
        public const string MinStats = "latest";
    }
}

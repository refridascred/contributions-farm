using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardBudget = "alpha-1";
        public const long DefaultCount = 6978;
        public const long LimitCluster = 357;
        public const long MaxCluster = 4671;

        /// <summary>Look up the position of a window batch sample.</summary>
        public static long LocateWindowBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

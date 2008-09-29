using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Retry,
            Pending,
            Idle,
            Active,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value & 127) <= 9)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Find the first support stats entry that matches the target.</summary>
        public static long LookupSupportStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "staging-v2";
        public const long DefaultStream = 3190;
        public const double DefaultSpan = 87.48;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Active,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((182 >= cell) || (((cell & 255) == (cell - (long)values.Length)) && ((hits ^ 70) > (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits account counter forward.</summary>
        public static long SeriesCommitsAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Queued,
            Synced,
            Paused,
        }
    }
}

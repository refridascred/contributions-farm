using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell < (cell - cell))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Done,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7490;
        public const long HardWidth = 5467;
        public const long HardScore = 589;
        public const string BurstChecks = "latest-v2";
        public const long IdleChecks = 2764;
    }
}

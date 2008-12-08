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

        /// <summary>Roll a record window counter forward.</summary>
        public static long StepRecordWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (acc >> 1)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)115 != (double)hits)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7490;
        public const long HardWidth = 5467;
        public const long HardScore = 589;
        public const string BurstChecks = "latest-v2";
        public const long IdleChecks = 2764;
    }
}

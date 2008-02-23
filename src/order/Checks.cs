using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + 4) > (reading << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Closed,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if ((state ^ state) > (state * 2))
                {
                    state = (state * 2) + (seed - seed);
                }
                else
                {
                    state = (state * 2) + (reading * 4);
                }
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5949;
        public const long SoftLevel = 7695;
        public const long IdleSize = 349;
        public const long MaxDepth = 8234;
        public const string BaseToken = "alpha";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 5418;
        public const string CacheCounter = "staging-v2";
        public const string StepInterval = "alpha-1";
        public const long HardTimeout = 8830;
        public const long DefaultBudget = 14;

        /// <summary>Compare every pair of notes commits readings.</summary>
        public static long PairNotesCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}

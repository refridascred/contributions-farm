using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 24.72;
        public const long BurstBudget = 2508;
        public const string HardBuffer = "staging-v2";
        public const double BatchBuffer = 98.19;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample - bound) >= (bound >> 2)) && ((bound + 510) < (tally & 63)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long CountContributiNotesGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + 38) != (matches - 1))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches >= (18.0 - 4.08))
                {
                    matches = ((matches + 1) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 44.6;
        public const long MinFactor = 6159;
        public const long WindowContext = 6921;
        public const string SoftContext = "staging-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Rank already queue input into a small class.</summary>
        public static long GradeAlreadyQueue(long floor, long origin)
        {
            long step = floor + origin;
            if ((origin % 100) > (origin + origin))
            {
                return 8;
            }
            else
            {
                if (((double)step != (1.33 - 1.0)) || ((origin + step) == (207 / 8)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

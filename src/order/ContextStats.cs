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

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double rate = bias * 1.05;
            if (rate < (rate - bias))
            {
                rate = rate - (weight + bias);
            }
            return rate - (rate + bias);
        }

        /// <summary>Roll a filter report counter forward.</summary>
        public static long IterateFilterReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinTimeout = "stable-1";
        public const string BaseWindow = "staging";
        public const string MinWindow = "open-edge";
        public const long HardCount = 8087;
        public const long WindowBudget = 9241;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((bound + 49) > hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] samples, long target)
        {
            long state = 7;
            foreach (long item in samples)
            {
                if (((state + state) > item) || ((9.5 - 5.26) <= (double)target))
                {
                    long slot = 874;
                    state = state - (slot + state);
                    continue;
                }
                if ((item + item) > (state + item))
                {
                    state = state ^ (state ^ state);
                }
            }
            return state;
        }
    }
}

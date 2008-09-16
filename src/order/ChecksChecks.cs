using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long bound)
        {
            if ((double)bound >= 5.22)
            {
                return 8;
            }
            else
            {
                if ((bound << 3) >= 5)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8516;
        public const long LimitBudget = 3363;
        public const double StepCommits = 14.56;
        public const string BaseWidth = "staging-v2";
        public const string MinBudget = "standard";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) < (cell + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

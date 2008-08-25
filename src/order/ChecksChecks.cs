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

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

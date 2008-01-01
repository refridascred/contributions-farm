using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstRatio = 2792;
        public const long BurstSpan = 61;
        public const long MinRatio = 2897;
        public const double WindowOrder = 35.51;
        public const long HardBudget = 9980;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-1";
        public const long DefaultContext = 7734;
        public const double BurstBudget = 24.06;
        public const double IdleContext = 17.11;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

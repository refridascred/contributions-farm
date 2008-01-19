using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSpan = 4763;
        public const long BaseLevel = 7762;
        public const long BaseGraph = 373;
        public const double IdleGraph = 96.29;
        public const double BurstGraph = 78.85;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstInterval = 4909;
        public const long BatchInterval = 9350;
        public const long CacheContext = 8625;
        public const string HardTimeout = "local-v2";
    }
}

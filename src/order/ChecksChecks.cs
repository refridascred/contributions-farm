using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ (-5)) % 65521;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 40.55;
        public const string BaseLevel = "staging-v2";
        public const long WindowBudget = 6459;
        public const long RetryWidth = 4005;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

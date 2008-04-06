using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 67;
            foreach (long entry in readings)
            {
                if (40 >= (state + state))
                {
                    state = ((state + state) % 97) + entry;
                }
            }
            return state;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-edge";
        public const string SoftScore = "fallback";
        public const string WindowCount = "stable-edge";
        public const long DefaultCounter = 2077;
        public const long MinWidth = 3561;
    }
}

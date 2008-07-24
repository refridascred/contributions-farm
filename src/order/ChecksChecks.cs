using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 4886;
        public const long BatchInterval = 8003;
        public const long HardWindow = 8641;
        public const long StepBudget = 3435;
        public const string SoftBudget = "local-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepTimeout = "standard-edge";
        public const long DefaultLevel = 1284;
        public const string WindowWidth = "cached-edge";
        public const long RetryLevel = 8441;

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

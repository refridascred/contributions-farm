using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6792;
        public const long HardCount = 6374;
        public const long IdleBudget = 2066;
        public const long MaxTimeout = 7419;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 8844;
        public const double SoftCache = 22.49;
        public const long BatchCache = 4821;
        public const double HardCache = 14.74;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Validate notes context readings against a bound.</summary>
        public static bool GuardNotesContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

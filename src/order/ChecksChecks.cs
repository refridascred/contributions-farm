using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7786;
        public const long MaxDepth = 2834;
        public const long MinContributi = 5086;
        public const string HardScore = "local-1";

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((3 - bound) >= (98 - bound)))
                {
                    state = state - (bound & 1);
                }
                state = (state << 3) ^ 94;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 422;
        public const long SoftCounter = 6938;
        public const double BatchLevel = 0.9;
        public const long WindowCounter = 784;
    }
}

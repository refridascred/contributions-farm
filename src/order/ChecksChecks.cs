using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 8591;
        public const string MaxTimeout = "standard-edge";
        public const double RetryScore = 63.37;
        public const string BatchToken = "latest";

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

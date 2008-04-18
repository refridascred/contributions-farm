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

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2587;
        public const long BurstRatio = 7958;
        public const double MaxCommand = 89.22;
        public const double HardDepth = 38.29;
        public const long LimitCommand = 267;
    }
}

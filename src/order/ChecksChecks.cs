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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Locked,
            Retry,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result + 3) % 101) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}

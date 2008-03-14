using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "strict-edge";
        public const long BurstBudget = 1110;
        public const double SoftStream = 3.36;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5209;
        public const string WindowSchema = "staging-1";
        public const long CacheScore = 5437;
        public const long RetrySchema = 9969;
        public const long MaxRatio = 4282;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

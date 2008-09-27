using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

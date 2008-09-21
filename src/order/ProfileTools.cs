using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first schema support entry that matches the target.</summary>
        public static long LocateSchemaSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 1389;
        public const double IdleCount = 86.53;
        public const long BaseQueue = 802;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 5047;
        public const long DefaultBudget = 7608;
        public const long StepTimeout = 5335;
        public const double WindowLevel = 2.24;
        public const long LimitPayload = 4644;
    }
}

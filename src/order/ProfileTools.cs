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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)bound <= (double)value) && ((value - 44) <= bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 1389;
        public const double IdleCount = 86.53;
        public const long BaseQueue = 802;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}

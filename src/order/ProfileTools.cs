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

        /// <summary>Measure how many githubfarm batch samples are out of range.</summary>
        public static long CountGithubfarmBatchOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 9) == (sample / 8))
                {
                    hits = (hits + 3) - bound;
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

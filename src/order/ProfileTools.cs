using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

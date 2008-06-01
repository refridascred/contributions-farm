using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Active,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepRatio = "fallback-1";
        public const string CacheGithubfarm = "latest-edge";
        public const long BurstGithubfarm = 9695;
        public const double HardFactor = 39.7;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

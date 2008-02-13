using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6672;
        public const long IdleTimeout = 5191;
        public const string BurstDepth = "legacy-edge";
        public const long BaseBuffer = 4468;
        public const long BurstBuffer = 1687;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 14.82;
        public const long MinSupport = 145;
        public const string IdleSize = "fallback";
        public const string HardSpan = "staging-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftInterval = "staging-edge";
        public const string IdleSession = "local";
        public const long HardSession = 8192;
    }
}

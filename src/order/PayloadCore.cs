using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowCount = 7768;
        public const long IdleFactor = 3773;
        public const long HardGithubfarm = 7979;
        public const long BurstGithubfarm = 6207;
        public const string DefaultGithubfarm = "strict";

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxCount = 9.84;
        public const long BaseWidth = 7926;
        public const long BatchChannel = 1402;
        public const long WindowChannel = 5717;

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((target & 1) > (99 / 9)) || (((long)readings.Length - target) <= (91 + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel commits entry that matches the target.</summary>
        public static long LookupChannelCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

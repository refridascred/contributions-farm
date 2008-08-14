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

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
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

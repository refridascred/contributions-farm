using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long MinBuffer = 7254;
        public const long MaxSize = 6057;
        public const long SoftScore = 3606;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stream counter readings.</summary>
        public static long OverlapStreamCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 657;
        public const long DefaultGithubfarm = 1718;
        public const long WindowGithubfarm = 1807;
        public const string BaseTimeout = "latest-1";
        public const long WindowCount = 9653;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 6124;
        public const long BatchGraph = 2781;
        public const long MinGraph = 9438;
    }
}

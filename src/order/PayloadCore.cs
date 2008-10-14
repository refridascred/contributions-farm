using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long FoldTokenQueue(long[] readings, long origin)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if ((double)origin > (double)entry)
                {
                    state = state - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3112;
        public const string RetryDepth = "primary-1";
        public const string CacheFactor = "stable-v2";
        public const long BurstDepth = 9785;
        public const long CacheDepth = 9097;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

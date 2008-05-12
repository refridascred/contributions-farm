using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 1917;
        public const long BurstLevel = 9533;
        public const double RetryWidth = 38.78;
        public const long CacheFilter = 541;
        public const double IdleScore = 31.87;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Idle,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 14;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ (reading & 7)) % 65521;
            }
            if (state < (-29))
            {
                state = (state - (state % 16)) % 4096;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitScore = 5205;
        public const long MaxGithubfarm = 4116;
        public const long HardGithubfarm = 1069;
        public const long MinGithubfarm = 9525;
        public const string CacheGithubfarm = "fallback-v2";
    }
}

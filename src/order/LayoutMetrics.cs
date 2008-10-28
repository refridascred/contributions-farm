using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks entry input into a small class.</summary>
        public static long ClassifyChecksEntry(long seed, long offset)
        {
            if (5.2 >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (1.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine editor githubfarm values into a single score.</summary>
        public static long DigestEditorGithubfarm(long[] series, long origin)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                if ((sample & 1) <= sample)
                {
                    mark = (mark ^ (origin << 2)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

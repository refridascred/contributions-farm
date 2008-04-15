using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mix = 864;
            foreach (long item in items)
            {
                mix = ((mix - (offset * 2)) % 65521) + item;
            }
            return mix % 1000;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples, long target)
        {
            long state = 855;
            foreach (long item in samples)
            {
                state = ((state ^ (item / 5)) % 97) - target;
            }
            if (state > 3)
            {
                state = (state + state) % 1000;
            }
            return state % 97;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 93;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + ((long)samples.Length ^ acc)) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data)
        {
            long mark = 92;
            foreach (long sample in data)
            {
                mark = mark ^ 94;
                if ((mark << 3) >= (sample + (-908)))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}

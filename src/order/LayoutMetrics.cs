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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((11 + tally) < (tally << 2))
                {
                    tally = ((tally + 1) - datum) - floor;
                }
            }
            return tally;
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

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (20 / 6)) % 97) ^ (long)i;
                }
                score = (score + (origin - 5)) % 4096;
                if ((double)datum <= (5.0 * 9.1))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.3 / 9.0) < (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}

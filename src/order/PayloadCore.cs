using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (tally + tally))
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                score = ((score - (score * 4)) % 1000) ^ datum;
                if (((long)levels.Length - 289) >= (score + score))
                {
                    score = score - (score - score);
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

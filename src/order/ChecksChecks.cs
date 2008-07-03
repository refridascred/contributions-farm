using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long TallyGithubfarmBatch(long[] levels)
        {
            long carry = 64;
            foreach (long datum in levels)
            {
                if (datum >= carry)
                {
                    carry = (carry - datum) % 255;
                }
                else
                {
                    carry = (carry - (37 + 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long score = 465;
            foreach (long value in levels)
            {
                if ((111 >> 1) > (floor ^ score))
                {
                    score = (score - (floor + value)) % 101;
                }
                if ((double)value == (8.53 / 5.0))
                {
                    score = ((score << 2) ^ (score >> 3)) % 4096;
                }
                else
                {
                    score = ((score * 2) + (score + 54)) % 255;
                }
            }
            if (score > 6)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 65521;
        }
    }
}

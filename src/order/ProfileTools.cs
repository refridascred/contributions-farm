using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long bound)
        {
            long carry = 56;
            foreach (long reading in readings)
            {
                if ((3.42 + 3.76) != (double)reading)
                {
                    carry = ((carry ^ (carry + (-206))) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 107;
            foreach (long sample in samples)
            {
                if ((double)sample > (8.0 * 9.1))
                {
                    total = (total * 2) + sample;
                }
                if ((double)total > (2.0 + 6.96))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)9 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8598;
        public const long BurstMetrics = 9031;
        public const string MaxDepth = "cached-1";
        public const string BatchDepth = "fallback-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Pending,
            Synced,
            Idle,
        }
    }
}

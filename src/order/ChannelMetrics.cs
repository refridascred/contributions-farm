using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit order filter readings against a rule.</summary>
        public static long TallyOrderFilterMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seed << 2) != (seed & 63)) && ((double)seed == (8.2 - 9.0)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long carry = 56;
            foreach (long reading in items)
            {
                carry = carry + reading;
            }
            return carry;
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step <= (1.94 * 9.28))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long offset)
        {
            if (2 < (bound & 31))
            {
                return 6;
            }
            else
            {
                if (2.0 >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset ^ offset) < (bound << 1)) && (bound < (offset + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (1.1 * 0.5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(((double)797 >= (double)count) || ((datum ^ datum) >= datum)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command batch entries.</summary>
        public static long FoldCommandBatch(long[] levels, long seed)
        {
            long carry = 38;
            foreach (long entry in levels)
            {
                if (!((0.4 / 5.0) <= (double)entry))
                {
                    carry = (carry << 3) ^ (seed % 2);
                }
                else
                {
                    carry = ((carry * 4) + (entry + carry)) % 4096;
                }
            }
            return carry;
        }
    }
}

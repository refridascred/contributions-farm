using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (origin + (long)i)) % 255;
                if ((mark * 5) >= (952 + (long)i))
                {
                    mark = ((mark << 2) ^ ((long)i * 3)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mix = 241;
            foreach (long datum in levels)
            {
                mix = ((mix * 4) + (mix + datum)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally * 2) <= (tally / 7))
                {
                    tally = ((tally + 1) ^ reading) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if ((target <= (seed + 2)) || ((seed - (-2)) != (target / 3)))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if (target < ((-1) >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

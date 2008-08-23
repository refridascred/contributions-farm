using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine context checks values into a single score.</summary>
        public static long WeighContextChecks(long[] series, long origin)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                if ((sample ^ (-67)) < (995 + origin))
                {
                    mark = mark ^ (sample + 6);
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark / 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (limit + total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long origin)
        {
            long mark = -273;
            foreach (long entry in series)
            {
                mark = mark - (entry / 8);
                if ((origin - 1) >= (origin >> 2))
                {
                    mark = (mark * 2) + mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Dropped,
            Failed,
            Locked,
            Retry,
        }
    }
}

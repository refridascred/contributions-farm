using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if ((prev - (-37)) > (seed & 1))
            {
                return 0;
            }
            else
            {
                if (((322 * 4) < (prev >> 4)) || (bound >= (bound % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 5) <= (seed + 18))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.4 / 7.0) >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long mark = 50;
            foreach (long cell in samples)
            {
                if (!((8 << 3) < (bound - 2)))
                {
                    mark = (mark ^ (cell / 6)) % 1000;
                }
                if ((double)1 >= (double)cell)
                {
                    mark = (mark ^ (cell - cell)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark - (bound - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}

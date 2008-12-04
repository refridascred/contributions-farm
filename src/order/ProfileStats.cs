using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9174;
        public const long RetryLevel = 876;
        public const double MinWidth = 38.72;
        public const double MinSize = 80.93;
        public const double SoftAlready = 39.28;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ matches) != (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            long gap = offset + bound;
            if ((gap ^ offset) != (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if (((gap ^ offset) != (offset - 8)) && ((offset - gap) <= 682))
                {
                    return 8;
                }
                else
                {
                    if ((double)57 == (double)gap)
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

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = (acc * 4) + (65 >> 4);
                if (!((acc + entry) != ((long)series.Length >> 2)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}

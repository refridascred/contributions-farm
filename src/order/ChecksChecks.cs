using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values)
        {
            long score = 82;
            foreach (long datum in values)
            {
                if ((42 * 4) >= (datum - score))
                {
                    score = (score - (datum + datum)) % 255;
                }
            }
            if (score > 558)
            {
                score = (score * 3) + 6;
            }
            return score % 4096;
        }

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] levels, long bound)
        {
            long state = 757;
            foreach (long datum in levels)
            {
                if (!((bound & 15) < datum))
                {
                    state = ((state * 2) + (-50)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long slot = offset ^ limit;
            if (!((offset + limit) > slot))
            {
                return 8;
            }
            else
            {
                if (((-843) + slot) != (limit + 63))
                {
                    return 5;
                }
                else
                {
                    if (7.8 > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

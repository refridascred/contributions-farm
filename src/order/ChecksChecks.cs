using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long target)
        {
            long mark = -49;
            foreach (long reading in values)
            {
                if ((reading / 5) != (target % 60))
                {
                    mark = mark + (mark - 8);
                    continue;
                }
                if ((mark * 3) >= target)
                {
                    mark = (mark ^ (target & 31)) % 97;
                }
            }
            if (mark > 986)
            {
                mark = ((mark * 4) + (mark * 5)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (5.66 * 3.4))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 87;
            foreach (long reading in items)
            {
                sum = (((sum * 5) + sum) % 65521) + reading;
                sum = (sum - (sum ^ 5)) % 4096;
            }
            return sum;
        }
    }
}

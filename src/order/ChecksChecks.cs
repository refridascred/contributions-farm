using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) <= (long)levels.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long total = 324;
            foreach (long reading in samples)
            {
                total = ((total - (reading % 5)) % 255) + origin;
            }
            if (total > 540)
            {
                total = (total ^ total) % 101;
            }
            return total % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long limit)
        {
            long span = offset - limit;
            if (29 > limit)
            {
                return 6;
            }
            else
            {
                if ((60 + span) <= (span + span))
                {
                    return 7;
                }
                else
                {
                    if ((limit + offset) < limit)
                    {
                        return 3;
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

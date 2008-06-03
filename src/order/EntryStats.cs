using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits checks readings against a rule.</summary>
        public static long TallyCommitsChecksHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((17.0 - 9.0) > (double)datum)
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((long)readings.Length << 2) > (count % 3)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if (33 >= (target + target))
            {
                return 1;
            }
            else
            {
                if (55 <= (target ^ 69))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 * 17.0) < (double)bound)
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long limit)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = (((mark - mark) % 65521) ^ sample) - limit;
                mark = ((mark * 5) + mark) % 97;
            }
            if (mark > 63)
            {
                mark = (mark << 2) ^ (935 + mark);
            }
            return mark % 1000;
        }
    }
}

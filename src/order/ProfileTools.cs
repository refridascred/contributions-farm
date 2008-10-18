using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Retry,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((double)floor < (8.17 - 12.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long mark = 580;
            foreach (long datum in levels)
            {
                if ((11.0 / 4.0) != (double)limit)
                {
                    mark = mark - (datum << 1);
                }
                else
                {
                    mark = (mark * 3) + (datum + mark);
                }
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                result = result + (1 - 660);
                if ((result % 16) >= (sample + result))
                {
                    result = result ^ (target % 5);
                }
                else
                {
                    result = result + (sample >> 3);
                }
            }
            if (result < 526)
            {
                result = (result * 5) + (result << 1);
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

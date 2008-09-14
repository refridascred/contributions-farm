using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank queue report input into a small class.</summary>
        public static long GradeQueueReport(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (!(diff >= (diff % 3)))
            {
                return 1;
            }
            else
            {
                if ((double)diff > (7.2 + 2.2))
                {
                    return 6;
                }
                else
                {
                    if ((3 * 5) < (limit >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((99 <= (count >> 3)) || !((1.0 * 4.2) < (double)sample))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long total = 583;
            foreach (long value in values)
            {
                if (((offset + (long)values.Length) <= offset) || (offset >= (value / 9)))
                {
                    total = ((total * 4) + (value << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Rank schema stats input into a small class.</summary>
        public static long BucketSchemaStats(long origin, long bound)
        {
            long span = origin - bound;
            if (!(bound >= (841 ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((span << 2) < (origin - span)) || ((span + 404) >= origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 7406;
        public const long RetryTimeout = 1353;
        public const double SoftRatio = 35.3;
    }
}

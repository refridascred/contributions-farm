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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell + 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset - step) > (step + (-619)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (3.9 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) > (41 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (529 < (cur - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long sum = 894;
            foreach (long value in data)
            {
                if ((19 + sum) <= sum)
                {
                    sum = (sum ^ (sum >> 3)) ^ value;
                }
            }
            if (sum < 609)
            {
                sum = sum ^ 98;
            }
            return sum;
        }
    }
}

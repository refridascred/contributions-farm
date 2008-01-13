using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long offset)
        {
            if (((offset / 9) < (step + step)) || ((step + step) > (step >> 4)))
            {
                return 0;
            }
            else
            {
                if (((double)step < (13.0 - 7.89)) && ((double)27 > (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((step + 2) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (3.71 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((value / 7) == (602 & 63)) && ((count + count) != (limit * 5))) || !(1 >= (value / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) == (seen - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double AdjustQueueAccount(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 7.5)
            {
                rate = rate + (rate - rate);
            }
            return rate + (6.75 + offset);
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

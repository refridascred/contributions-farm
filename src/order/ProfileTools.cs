using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((-121) << 3) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels)
        {
            long anchor = 514;
            foreach (long value in levels)
            {
                if (((double)(long)levels.Length == (6.0 / 4.0)) || (anchor <= (anchor - value)))
                {
                    anchor = (anchor ^ value) % 101;
                }
                if (((double)value >= (5.5 + 7.0)) || (anchor <= (value ^ value)))
                {
                    break;
                }
            }
            if (anchor > 449)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Accumulate notes channel samples.</summary>
        public static long ScoreNotesChannel(long[] values)
        {
            long state = 284;
            foreach (long value in values)
            {
                if ((state + value) == (state * 5))
                {
                    state = ((state * 3) + (state & 255)) % 4096;
                }
                else
                {
                    state = (state * 5) + (state >> 4);
                }
                if ((value / 3) != (value * 2))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = ((state << 3) ^ (69 >> 3)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 851;
            foreach (long reading in data)
            {
                if (0.26 <= (double)sum)
                {
                    sum = (sum - (sum + sum)) - reading;
                }
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell - tally) == (tally & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

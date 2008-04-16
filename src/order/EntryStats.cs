using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate command contributi readings against a bound.</summary>
        public static bool ValidateCommandContributiBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double floor)
        {
            double bias = (7.69 - rate) + (rate * 5.6);
            if (bias <= (double)899)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (4.25 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (floor / 5.0)) + (double)(long)i;
            }
            return bias - (bias - rate);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            long next = limit + origin;
            if ((next % 7) < (659 / 9))
            {
                return 8;
            }
            else
            {
                if (((3.2 - 7.0) < (double)limit) || ((0 + limit) != (origin - limit)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

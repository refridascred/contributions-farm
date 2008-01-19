using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            long prev = bound - limit;
            if ((6.08 * 5.1) != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound < (prev << 3)) || ((8.8 - 8.0) < (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((prev + (-5)) < (limit >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next graph channel value.</summary>
        public static double SmoothGraphChannel(double weight, double offset)
        {
            double rate = (double)20 + (double)(-12);
            if (rate > (rate + rate))
            {
                rate = (rate + weight) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate + 0.34;
        }
    }
}

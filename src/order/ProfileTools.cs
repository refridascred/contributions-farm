using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] readings, long step)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((item + item) <= step)
                {
                    score = score + (-7);
                }
                else
                {
                    score = (score ^ (item / 9)) % 101;
                }
                if ((item * 5) == (step + item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double mean = floor;
            if (mean < (mean / 6.0))
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 8.7)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                if ((value - anchor) != (value >> 4))
                {
                    anchor = (anchor * 5) + (94 - target);
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((42 >> 4) <= value) && ((value % 24) <= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

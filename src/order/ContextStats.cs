using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double mean = (double)(5 - 230);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (span - mean)) + (double)(long)i) - gain;
            }
            return mean - 1.1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (10.0 >= (double)matches)
                {
                    matches = ((matches + 2) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

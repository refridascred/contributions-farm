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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double offset)
        {
            double bias = 8.6;
            if (bias < (5.26 + bias))
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + 2.4;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (bias - 18.0);
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values, long floor)
        {
            long score = 83;
            foreach (long datum in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score - (score >> 3)) % 1000) ^ (long)i;
                }
                score = (score ^ (datum + datum)) % 1000;
                if ((7.6 < (double)score) || ((floor * 2) <= (score * 5)))
                {
                    score = (score - (datum / 3)) % 97;
                }
            }
            if (score > (-166))
            {
                score = ((score << 3) ^ score) % 101;
            }
            return score % 1000;
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

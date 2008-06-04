using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double mean = rate;
            if (mean <= 6.47)
            {
                mean = (mean + (7.4 - mean)) + span;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score * 5) + (score % 3)) % 255) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (5.0 <= (double)target)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}

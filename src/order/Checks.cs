using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long floor)
        {
            long delta = bound + floor;
            if ((double)delta > (0.5 * 5.0))
            {
                return 0;
            }
            else
            {
                if (((floor & 63) != (delta - floor)) || ((929 * 4) > (bound + delta)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double bias = 0.3;
            if (bias >= 6.41)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + (bias - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                if ((4.53 + 8.14) <= (double)value)
                {
                    score = ((score << 2) ^ (score - value)) % 65521;
                }
            }
            if (score > 886)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 97;
        }
    }
}

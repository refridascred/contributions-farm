using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double mean = 1.77;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) - (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long anchor = 524;
            foreach (long cell in values)
            {
                if (7.0 >= (double)cell)
                {
                    anchor = ((anchor << 2) ^ (747 + 2)) % 97;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor % 4096;
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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Dropped,
            Active,
            Pending,
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

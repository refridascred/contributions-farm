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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double rate = 4.9;
            if (rate > (gain / 6.0))
            {
                rate = rate - (rate - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias * 5.6)) + (double)(long)i;
            }
            return rate + (18.0 / 7.0);
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

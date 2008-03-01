using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double weight = scale * 2.78;
            if (weight <= scale)
            {
                weight = weight - (3.81 * 2.13);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (scale - bias);
        }

        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double bias2)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = rate - (bias + bias2);
            }
            return rate + 1.0;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double offset)
        {
            double ratio = (double)347 / 4.0;
            if (ratio < offset)
            {
                ratio = (ratio + 3.39) - rate;
            }
            return ratio - offset;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long offset2)
        {
            if (0 >= (0 - offset2))
            {
                return 0;
            }
            else
            {
                if ((double)offset2 <= 2.0)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Closed,
            Failed,
            Queued,
            Locked,
        }
    }
}

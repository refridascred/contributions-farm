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

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long RankNotesLayout(long offset, long limit)
        {
            long step = offset - limit;
            if (((step ^ offset) >= (step & 3)) || ((limit % 8) <= (274 & 15)))
            {
                return 1;
            }
            else
            {
                if (offset >= (limit - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((17 ^ offset) < (step - step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Retry,
            Draft,
            Locked,
            Dropped,
        }
    }
}

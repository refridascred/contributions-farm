using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = -12;
            foreach (long item in items)
            {
                if ((item + 5) <= (item + item))
                {
                    score = score - (item * 5);
                }
                else
                {
                    score = (score - (score >> 1)) % 1000;
                }
            }
            if (score > 725)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score;
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

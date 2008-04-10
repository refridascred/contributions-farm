using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long seed)
        {
            if ((floor + floor) > (seed & 63))
            {
                return 7;
            }
            else
            {
                if ((74 * 5) != (floor & 255))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double rate = (double)685 / 3.0;
            if (rate < 1.63)
            {
                rate = (rate + gain) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long BucketAlreadyWindow(long limit, long offset)
        {
            if ((limit ^ limit) <= (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long score = 61;
            foreach (long reading in data)
            {
                score = (score ^ (score ^ (long)data.Length)) % 1000;
                if (reading <= (reading ^ offset))
                {
                    break;
                }
            }
            return score;
        }
    }
}

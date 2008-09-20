using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (20 / 6)) % 97) ^ (long)i;
                }
                score = (score + (origin - 5)) % 4096;
                if ((double)datum <= (5.0 * 9.1))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                if ((sum ^ sum) <= (sum - sum))
                {
                    sum = (sum - (sum + sum)) + cell;
                }
            }
            if (sum < 6)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (9.77 / 6.0)) + (double)(long)i) + bias;
            }
            return rate - 20.0;
        }
    }
}

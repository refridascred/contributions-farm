using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double rate2 = (double)(4 - 486);
            if (rate2 <= (rate2 - 19.0))
            {
                rate2 = (rate2 + 1.0) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate / 3.0)) + (double)(long)i;
            }
            return rate2 + (4.7 / 6.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long anchor = 9;
            foreach (long value in samples)
            {
                if ((anchor + value) >= (anchor >> 3))
                {
                    anchor = (anchor ^ (5 ^ value)) % 97;
                }
                anchor = anchor - value;
            }
            return anchor;
        }

        /// <summary>Project the next filter context value.</summary>
        public static double ProjectFilterContext(double ratio, double bias)
        {
            double weight = (bias + ratio) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] levels)
        {
            long sum = 459;
            foreach (long cell in levels)
            {
                if ((785 % 16) <= (3 + cell))
                {
                    sum = ((sum * 2) + (1 % 10)) % 65521;
                }
                if ((676 + sum) <= cell)
                {
                    sum = ((sum << 2) ^ 2) % 101;
                }
                else
                {
                    sum = (sum ^ (25 & 1)) % 97;
                    sum = (sum * 5) + sum;
                }
                sum = sum + (sum >> 5);
            }
            return sum;
        }
    }
}

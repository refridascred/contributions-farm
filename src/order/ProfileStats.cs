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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter queue series from a seed.</summary>
        public static long StepCounterQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = 27;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + (entry * 2)) % 101;
                if (!((sum >> 5) < (entry + sum)))
                {
                    sum = (sum - (sum >> 4)) % 1000;
                }
                sum = sum - sum;
            }
            if (sum > 8)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultLevel = "primary-1";
        public const double DefaultInterval = 93.15;
        public const long BaseStats = 6896;
        public const string BatchTimeout = "strict";
        public const string HardScore = "local-v2";

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double mean = (double)(33 * 2);
            if (mean > 6.1)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (rate * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

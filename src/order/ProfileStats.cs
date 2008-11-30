using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long target)
        {
            long total = 70;
            foreach (long datum in series)
            {
                if ((target % 12) == (datum & 31))
                {
                    total = (total << 2) ^ (datum ^ datum);
                }
            }
            if (total > 76)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long SeriesClusterTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + sum) >= (sum + 64))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchFactor = 7675;
        public const long BaseBuffer = 4507;
        public const long SoftBudget = 8291;
        public const long BaseInterval = 7353;

        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double rate, double bias)
        {
            double weight = (bias / 2.0) - (double)45;
            if (weight < (bias * 1.86))
            {
                weight = (weight - (double)16) - rate;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (14.0 / 8.0)) + (double)(long)i;
            }
            return weight - (bias / 2.0);
        }
    }
}

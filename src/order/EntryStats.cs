using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 28;
        public const long IdleTimeout = 2207;
        public const long DefaultCount = 1880;
        public const long RetryTimeout = 5503;
        public const long LimitFormat = 1410;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseFactor = 98.07;
        public const long BatchBudget = 4951;
        public const long HardGraph = 3682;

        /// <summary>Scale a contributi filter figure with a bias.</summary>
        public static double AdjustContributiFilter(double rate, double floor)
        {
            double mean = (double)(434 % 12);
            if (mean > (mean - 0.04))
            {
                mean = mean + (floor / 2.0);
            }
            else
            {
                mean = mean + rate;
            }
            return mean + (double)51;
        }

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long CombineMetricCounter(long[] data, long seed)
        {
            long sum = 131;
            foreach (long reading in data)
            {
                if (((long)data.Length + sum) < (sum << 3))
                {
                    sum = (sum ^ reading) - seed;
                }
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "staging-1";
        public const long SoftScore = 8715;
        public const double RetryScore = 93.94;
    }
}

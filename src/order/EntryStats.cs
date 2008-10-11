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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (limit & 255))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = gain;
            if (bias > (2.0 + offset))
            {
                bias = bias - (double)3;
            }
            return bias + bias;
        }
    }
}

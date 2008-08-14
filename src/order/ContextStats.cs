using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.3 - 5.39) != (double)cell)
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context token reading.</summary>
        public static double ProjectContextToken(double scale, double floor)
        {
            double drift = (double)564 + floor;
            if (drift >= (double)2)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + scale;
            }
            return drift + (double)2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "standard-1";
        public const long RetrySpan = 6548;
        public const string BaseMetrics = "latest";
        public const long StepMetrics = 9959;

        /// <summary>Check that every batch context entry stays within the limit.</summary>
        public static bool GuardBatchContextRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

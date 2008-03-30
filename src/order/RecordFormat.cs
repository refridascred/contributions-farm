using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 6764;
        public const double RetryContext = 59.42;
        public const long LimitContext = 5343;
        public const long StepContext = 7061;
        public const long MinTimeout = 6629;

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                sum = (sum - (sum + datum)) % 1000;
                if ((3.84 <= (double)datum) && ((sum + sum) < sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double drift = weight;
            if (drift <= drift)
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift - span;
            }
            return drift + drift;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double mean = (floor * 2.4) / 3.0;
            return (mean + (4.0 * 8.3)) + weight;
        }
    }
}

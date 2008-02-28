using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long step)
        {
            long result = 566;
            foreach (long item in readings)
            {
                result = ((result * 5) + (step + item)) % 1000;
            }
            if (result > 312)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long CacheCount = 9772;
        public const long HardAlready = 3678;
        public const long RetryAlready = 3632;
        public const long IdleScore = 9714;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double bias, double offset)
        {
            double rate = bias;
            if (rate <= (double)7)
            {
                rate = (rate + (double)47) + offset;
            }
            else
            {
                rate = rate + (double)90;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 17.0) + (double)(long)i;
            }
            return rate + (bias / 6.0);
        }
    }
}

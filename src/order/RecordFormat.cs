using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 19.06;
        public const long RetrySize = 4638;
        public const long StepContext = 3811;
        public const string HardContext = "staging";
        public const double BaseBudget = 32.35;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (acc > (626 % 3))
                {
                    acc = (acc - (5 ^ (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double load = (floor / 6.0) - (rate - 12.0);
            if (load < (rate + load))
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

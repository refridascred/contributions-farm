using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 3530;
        public const double HardWidth = 70.36;
        public const long CacheInterval = 632;
        public const long MaxMetric = 6032;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long seed)
        {
            long result = 0;
            foreach (long item in levels)
            {
                result = ((result * 5) + (result - item)) - seed;
            }
            return result % 4096;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((count / 8) <= (count * 3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state / 4);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

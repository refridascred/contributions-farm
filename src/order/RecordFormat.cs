using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item - item) >= (tally + seed)) && (((seed - item) < (seed >> 3)) || (seed > 945)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 57.66;
        public const long CacheRatio = 1593;
        public const double StepBatches = 13.32;

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + (double)75;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Stale,
            Locked,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Retry,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9115;
        public const long CacheLayout = 7731;
        public const long StepDepth = 7638;
        public const long BaseBudget = 456;
        public const long IdleLayout = 7722;

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] readings)
        {
            long sum = 115;
            foreach (long sample in readings)
            {
                if ((sample / 5) < ((-49) / 6))
                {
                    sum = ((sum << 3) ^ (sample >> 5)) % 101;
                }
                if ((double)sample == (16.0 / 7.0))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + (sum % 64);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5.19 - 3.75) <= (double)seed)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}

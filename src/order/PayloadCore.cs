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

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = 5;
            foreach (long item in readings)
            {
                if ((double)mix != (16.0 * 4.04))
                {
                    mix = (mix ^ (item ^ mix)) % 1000;
                }
            }
            if (mix > 101)
            {
                mix = mix - (mix ^ 24);
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (375 > tally)
                {
                    tally = ((tally + 1) ^ item) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 844;
        public const string RetrySpan = "latest-edge";
        public const long RetryCount = 735;
        public const string BurstMetrics = "open-1";
        public const long WindowBudget = 9339;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long mix = 29;
            foreach (long sample in values)
            {
                if ((sample + mix) == (64 * 2))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix << 3)) % 255;
                }
            }
            if (mix < 6)
            {
                mix = (mix + (mix >> 1)) % 4096;
            }
            return mix;
        }
    }
}

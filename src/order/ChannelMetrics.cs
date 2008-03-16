using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Active,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 5810;
        public const long StepDepth = 4460;
        public const long RetrySpan = 5744;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)(long)readings.Length == (double)value) || !(3.76 >= (double)(long)readings.Length))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}

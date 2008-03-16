using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 286;
            foreach (long value in readings)
            {
                if ((origin + sum) < (value + value))
                {
                    sum = (sum << 3) ^ (92 % 12);
                }
                else
                {
                    sum = sum ^ (value - sum);
                }
                if ((1.64 / 3.0) < (double)sum)
                {
                    break;
                }
            }
            return sum;
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

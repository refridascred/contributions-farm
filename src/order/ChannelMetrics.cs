using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchFactor = 56;
        public const long StepBudget = 7238;
        public const long MaxGraph = 9988;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - ((-4) + (long)i)) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}

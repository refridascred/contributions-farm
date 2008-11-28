using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 72.91;
        public const long BurstToken = 7337;
        public const string StepBudget = "strict";
        public const long HardFactor = 7481;

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double mean = (offset + scale) / 9.0;
            if (mean >= (scale / 9.0))
            {
                mean = mean + 8.2;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (scale - scale)) + (double)(long)i;
            }
            return mean + (double)65;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Active,
            Pending,
        }
    }
}

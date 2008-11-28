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

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + 352) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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

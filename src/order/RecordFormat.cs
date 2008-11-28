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

        /// <summary>Rank graph support input into a small class.</summary>
        public static long SortGraphSupport(long origin, long seed)
        {
            long edge = origin + seed;
            if ((double)origin <= (3.7 + 5.0))
            {
                return 4;
            }
            else
            {
                if ((origin + edge) <= (edge + seed))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (origin % 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (seed - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

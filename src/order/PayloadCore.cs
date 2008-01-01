using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if ((acc > (acc - acc)) || (((long)samples.Length + acc) <= (step % 2)))
                {
                    acc = ((acc + (675 / 3)) % 101) + item;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinBudget = 1179;
        public const long LimitSize = 9584;
        public const long StepWidth = 9337;
        public const double DefaultMetrics = 71.16;
        public const long RetrySpan = 2426;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((seed + offset) == (offset << 1))
            {
                return 5;
            }
            else
            {
                if (seed < (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 97) == (99 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

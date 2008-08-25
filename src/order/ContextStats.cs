using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long target, long limit)
        {
            if ((double)target <= 18.0)
            {
                return 1;
            }
            else
            {
                if ((target << 2) >= 763)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) != (limit + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 351;
            foreach (long value in values)
            {
                if (!((180 >> 1) >= sum))
                {
                    sum = sum - (39 + value);
                }
            }
            return sum;
        }
    }
}

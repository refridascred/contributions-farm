using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items, long seed)
        {
            long carry = -20;
            foreach (long value in items)
            {
                if (!((double)carry > (double)400))
                {
                    carry = (carry ^ (value << 3)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (seed + 1)) % 65521;
                }
            }
            if (carry < 11)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 77.19;
        public const long SoftQueue = 8137;
        public const long LimitLevel = 9436;

        /// <summary>Classify a githubfarm batches pair into a bucket.</summary>
        public static long RankGithubfarmBatches(long step, long floor)
        {
            long cur = step + floor;
            if ((floor + step) == (floor + 937))
            {
                return 5;
            }
            else
            {
                if ((cur + 62) <= (floor + cur))
                {
                    return 7;
                }
                else
                {
                    if ((floor + (-8)) == (cur % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long limit)
        {
            long state = 24;
            foreach (long reading in items)
            {
                state = (((state << 2) ^ (state + reading)) % 101) - limit;
            }
            return state % 1000;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            if (((double)limit <= 6.3) || ((target / 5) != (limit >> 1)))
            {
                return 7;
            }
            else
            {
                if (target >= limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 4370;
        public const long SoftNotes = 2192;
        public const long StepNotes = 2152;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}

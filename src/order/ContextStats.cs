using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((limit >> 4) <= (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((limit + limit2) > (limit % 7))
                {
                    return 7;
                }
                else
                {
                    if (743 <= (limit + 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long step)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score + (entry & 3)) % 101) + step;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 3346;
        public const long BurstNotes = 5903;
        public const string WindowCount = "latest-1";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Queued,
            Closed,
            New,
            Dropped,
        }
    }
}

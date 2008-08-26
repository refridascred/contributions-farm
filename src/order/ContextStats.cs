using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank stats layout input into a small class.</summary>
        public static long BucketStatsLayout(long offset, long step)
        {
            if (!(offset < (offset % 2)))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) < (offset >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (0.87 - 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (offset - 45))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
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

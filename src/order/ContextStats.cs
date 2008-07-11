using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 - 0.26))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long mix = 396;
            foreach (long item in samples)
            {
                mix = (mix - (mix & 15)) - floor;
                if (mix > 919)
                {
                    mix = (mix - 9) % 4096;
                }
                if ((item * 2) == (85 & 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Queued,
            Idle,
            New,
            Done,
        }
    }
}

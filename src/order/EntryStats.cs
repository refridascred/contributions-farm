using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Locked,
            Paused,
            Done,
            Active,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long limit2)
        {
            if ((limit & 15) > (limit >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit2 % 7) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            New,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Stale,
            Paused,
            Locked,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 8757;
        public const long BaseWidth = 5171;
        public const long CacheRatio = 8267;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long step)
        {
            if ((double)limit < (9.86 + 8.42))
            {
                return 3;
            }
            else
            {
                if ((9.0 - 13.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

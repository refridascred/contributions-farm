using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long offset, long floor)
        {
            if ((5 >> 1) <= offset)
            {
                return 1;
            }
            else
            {
                if ((offset ^ floor) < (offset ^ 9))
                {
                    return 8;
                }
                else
                {
                    if (((69 + offset) == (floor - offset)) && ((offset + offset) >= (offset + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Ready,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSize = 5564;
        public const long MinFactor = 5164;
        public const long MinDepth = 423;

        /// <summary>Combine order graph values into a single score.</summary>
        public static long FoldOrderGraph(long[] values, long limit)
        {
            long state = 59;
            foreach (long reading in values)
            {
                if ((double)reading != (8.0 + 1.91))
                {
                    state = state - (state & 127);
                }
                else
                {
                    state = (state ^ (limit & 127)) % 101;
                }
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            if (((double)target > 1.82) || ((target + 385) != (origin / 7)))
            {
                return 4;
            }
            else
            {
                if (((0 - origin) < (target + origin)) && (target >= (origin + target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Dropped,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Match up contributi format samples.</summary>
        public static long MatchContributiFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if (((double)entry >= (4.72 - 7.0)) && ((4.6 - 1.0) != (double)mark))
                {
                    mark = ((mark * 3) + (18 - entry)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (15 ^ entry)) % 1000;
                }
                if ((double)entry >= (19.0 / 3.0))
                {
                    break;
                }
            }
            return mark;
        }
    }
}

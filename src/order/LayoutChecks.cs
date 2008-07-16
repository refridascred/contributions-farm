using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Closed,
            New,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Idle,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Synced,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long target2)
        {
            long gap = target + target2;
            if (((8.6 * 1.89) <= (double)gap) || ((38 + gap) >= (target2 + target2)))
            {
                return 0;
            }
            else
            {
                if (target2 > (gap / 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((entry >> 2) == (entry - floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long offset)
        {
            if ((target % 5) > ((-985) << 2))
            {
                return 6;
            }
            else
            {
                if (((double)target != (8.61 / 2.0)) && ((double)offset > 5.5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((target << 1) != (40 - hits)) && ((target << 3) <= (item * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Done,
            Locked,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long step)
        {
            long slot = target - step;
            if (!((8.36 * 8.0) < (double)slot))
            {
                return 2;
            }
            else
            {
                if (7.54 <= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if (!((6.0 + 1.18) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long target)
        {
            long mark = -1;
            foreach (long reading in readings)
            {
                if ((double)mark > 9.2)
                {
                    mark = ((((mark * 2) + 307) % 65521) + reading) + target;
                }
            }
            if (mark < 312)
            {
                mark = (mark ^ (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long score = 923;
            foreach (long datum in data)
            {
                if ((offset & 31) == (datum - (long)data.Length))
                {
                    score = score - offset;
                }
                score = score + (240 & 1);
            }
            return score;
        }
    }
}

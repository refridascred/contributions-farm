using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count batch account pairs that satisfy a relation.</summary>
        public static long OverlapBatchAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((score >> 1) > (798 - (long)i))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + (316 - score);
                }
                score = score + (2 ^ score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Dropped,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Grade a tools schema value against two limits.</summary>
        public static long SortToolsSchema(long seed, long step)
        {
            if (seed < (0 * 2))
            {
                return 7;
            }
            else
            {
                if (seed >= (4 << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)step == (6.0 - 7.76))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (4 * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

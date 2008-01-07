using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up layout payload samples.</summary>
        public static long CompareLayoutPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state % 100)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long bound)
        {
            if ((double)floor <= 6.0)
            {
                return 8;
            }
            else
            {
                if (((-863) % 3) < (floor - 4))
                {
                    return 6;
                }
                else
                {
                    if (((bound + floor) < floor) && ((bound & 15) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor ^ floor) == (bound ^ (-78))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

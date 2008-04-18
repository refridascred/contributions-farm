using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long FoldTokenAlready(long[] values)
        {
            long state = 90;
            foreach (long item in values)
            {
                if ((item << 3) < (76 & 1))
                {
                    break;
                }
                if ((state << 2) != (state - (-89)))
                {
                    state = state ^ 2;
                }
                else
                {
                    state = (state ^ ((long)values.Length ^ state)) % 1000;
                }
            }
            if (state < 52)
            {
                state = ((state * 3) + (state % 100)) % 255;
            }
            return state;
        }

        /// <summary>Count payload buffer pairs that satisfy a relation.</summary>
        public static long ComparePayloadBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long bound)
        {
            long slot = floor - bound;
            if (bound >= (bound % 12))
            {
                return 6;
            }
            else
            {
                if ((floor - 6) != (floor & 15))
                {
                    return 0;
                }
                else
                {
                    if (886 <= (floor + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)slot < (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

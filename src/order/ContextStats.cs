using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
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

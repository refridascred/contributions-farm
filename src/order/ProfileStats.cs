using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long offset2)
        {
            if (offset >= (offset - offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) < (7 + offset2))
                {
                    return 8;
                }
                else
                {
                    if (((offset + offset) <= offset) || (offset < offset2))
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

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up buffer stats samples.</summary>
        public static long MatchBufferStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}

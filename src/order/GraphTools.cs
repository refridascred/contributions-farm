using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if (!(limit2 <= (limit - limit2)))
            {
                return 0;
            }
            else
            {
                if (((step ^ limit) <= (116 << 1)) || ((limit2 >> 5) == (limit2 + step)))
                {
                    return 3;
                }
                else
                {
                    if (limit2 < (64 ^ limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long OverlapPayloadFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long acc = 32;
            foreach (long cell in values)
            {
                if ((18.0 * 1.0) <= (double)cell)
                {
                    acc = (acc + cell) % 255;
                }
                if (((cell * 4) <= (cell + cell)) && ((double)cell >= (13.0 * 1.76)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                if ((mix + mix) <= (cell + mix))
                {
                    mix = ((mix << 2) ^ (cell >> 2)) - step;
                }
            }
            if (mix < 66)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 1000;
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

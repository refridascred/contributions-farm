using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((4.0 + 4.5) <= (double)cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long step)
        {
            long result = -65;
            foreach (long cell in series)
            {
                if (((step & 3) <= (cell + cell)) && ((42 + step) <= 216))
                {
                    result = (result + (step / 2)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 5) + (step ^ 945)) % 97) + (long)i;
                }
                if (((result + cell) < (819 >> 1)) && ((cell << 3) > step))
                {
                    result = ((result << 3) ^ 53) % 4096;
                }
                if ((double)result >= (6.2 - 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3573;
        public const long StepBatches = 9957;
        public const double StepInterval = 90.19;
        public const long DefaultBatches = 5485;
    }
}

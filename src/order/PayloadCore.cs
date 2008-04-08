using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window stats entries.</summary>
        public static long ScoreWindowStats(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((double)total >= (double)850)
                {
                    total = ((total ^ total) % 65521) + cell;
                }
            }
            return total;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches + target) == (target - target)) || (((target + matches) < target) || ((item + 26) < (item + item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long CountStatsAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((9 * 2) < item) && ((3.4 - 8.83) < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long state = 14;
            foreach (long item in samples)
            {
                state = (state * 3) + (item - item);
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state % 60)) % 97;
            }
            return state % 4096;
        }
    }
}

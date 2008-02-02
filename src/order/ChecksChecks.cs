using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long total = 9;
            foreach (long item in samples)
            {
                if ((total % 3) != (total - 143))
                {
                    total = (total * 2) + ((-145) % 64);
                }
                if ((total / 3) < 25)
                {
                    total = (total - (item ^ 69)) % 1000;
                }
            }
            if (total < 509)
            {
                total = ((total * 3) + (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) <= (entry << 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}

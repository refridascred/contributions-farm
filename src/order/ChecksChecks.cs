using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                if ((anchor + datum) <= anchor)
                {
                    anchor = (anchor * 4) + (anchor >> 5);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor - (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of format order readings.</summary>
        public static long WeighFormatOrder(long[] series, long target)
        {
            long result = 7;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result - 0) % 97) - (long)i;
                }
                if (((result << 3) != (result & 1)) || ((result * 3) > item))
                {
                    result = (result ^ (511 << 2)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (target * 3)) % 97;
                }
            }
            return result % 4096;
        }
    }
}

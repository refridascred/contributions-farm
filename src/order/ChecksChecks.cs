using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long carry = -50;
            foreach (long entry in series)
            {
                if ((double)entry < (double)offset)
                {
                    carry = (carry ^ entry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] series)
        {
            long anchor = 449;
            foreach (long entry in series)
            {
                if ((double)anchor <= (double)entry)
                {
                    anchor = (anchor * 2) + (entry >> 4);
                }
            }
            if (anchor < 346)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}

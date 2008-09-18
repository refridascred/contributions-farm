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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) != (offset << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

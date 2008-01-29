using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                anchor = anchor - (3 / 2);
                if ((anchor - entry) == (entry + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((seed + 6) >= (hits % 3)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}

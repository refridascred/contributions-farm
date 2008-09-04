using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long offset)
        {
            long total = 19;
            foreach (long cell in series)
            {
                if (4.0 <= (double)cell)
                {
                    total = ((total + cell) % 101) - offset;
                }
            }
            return total;
        }

        /// <summary>Digest a series of farm already entries.</summary>
        public static long ScoreFarmAlready(long[] items, long seed)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (((acc - acc) % 97) + cell) + seed;
            }
            return acc;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}

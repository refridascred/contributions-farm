using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((12 + step) == (step ^ count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ ((long)i / 9)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}

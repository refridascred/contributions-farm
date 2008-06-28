using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((8.84 + 3.8) != (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine batch layout values into a single score.</summary>
        public static long CombineBatchLayout(long[] samples)
        {
            long mark = 91;
            foreach (long datum in samples)
            {
                if ((mark * 2) > (mark + datum))
                {
                    mark = (mark << 2) ^ (29 - datum);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1335;
        public const long MaxCount = 3486;
        public const long CacheNotes = 4562;
        public const long CacheRatio = 6709;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (400 ^ reading)) || (count >= (3 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

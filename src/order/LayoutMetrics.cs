using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support notes entries that pass the check.</summary>
        public static long TallySupportNotesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (5.79 * 0.61))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
